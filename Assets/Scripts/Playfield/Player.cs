using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Playfield
{
    public class Player : MonoBehaviour
    {
        [HideInInspector]
        public BasePlayer m_BasePlayer;
        [HideInInspector]
        public bool needDir = false;

        private int numberOfPoints = -1;
        private Vector2 moveDirection;
        private bool MovePlayer = false;
        private Vector3 destination;

        public int MovePoints
        {
            get
            {
                return numberOfPoints;
            }
            set
            {
                numberOfPoints = value;
                UIManager.Instance.SetMovePoints(numberOfPoints);
            }
        }

        private void Update()
        {
            if (MovePoints != -1) //if the player rolled the dices
                if (MovePlayer && !needDir) //if the Player can move and dont need a new direction
                {
                    transform.position = Vector3.MoveTowards(transform.position, destination, Time.deltaTime * 8f); //Move Player
                    if (transform.position == destination) //if Player reached the destination
                    {
                        MovePlayer = false; //player cant move
                        m_BasePlayer.m_PlayfieldPos = new Vector2Int(m_BasePlayer.m_PlayfieldPos.x + (int)moveDirection.x, m_BasePlayer.m_PlayfieldPos.y + (int)moveDirection.y); //Update his Position in the BasePlayer
                        MovePoints--; //Reduce the Amount of Moves
                        return;
                    }
                }
                else if (MovePoints != 0) // if the player cant Move, need a need Direction but not all his Moves were done
                {
                    if (PlayfieldManager.GetAmountOfNeigbors(m_BasePlayer.m_PlayfieldPos) == 2) //if the Player cant deside a new direction (go around a corner)
                    {
                        if (moveDirection != Vector2.zero) //if the movement is not zero
                            if (PlayfieldManager.CheckForMove(m_BasePlayer.m_PlayfieldPos, moveDirection)) //if the Player can move in this Direction
                            {
                                //Move the Player
                                destination = GridFieldGenerator.m_Grid.Field[m_BasePlayer.m_PlayfieldPos.x + (int)moveDirection.x, m_BasePlayer.m_PlayfieldPos.y + (int)moveDirection.y].StayPos;
                                MovePlayer = true;
                            }
                            else //if the Player cant move in this direction
                            {
                                //check for left and right possible directions
                                Vector2 toCheck = new Vector2();
                                switch (moveDirection.x)
                                {
                                    case 0:
                                        break;
                                    case 1:
                                    case -1:
                                        toCheck = new Vector2(0, 1);
                                        break;
                                }
                                switch (moveDirection.y)
                                {
                                    case 0:
                                        break;
                                    case 1:
                                    case -1:
                                        toCheck = new Vector2(1, 0);
                                        break;
                                }

                                if (PlayfieldManager.CheckForMove(m_BasePlayer.m_PlayfieldPos, toCheck))
                                    moveDirection = toCheck;
                                else if (PlayfieldManager.CheckForMove(m_BasePlayer.m_PlayfieldPos, -toCheck))
                                    moveDirection = -toCheck;

                                //move around the corner + update the new direction
                                destination = GridFieldGenerator.m_Grid.Field[m_BasePlayer.m_PlayfieldPos.x + (int)moveDirection.x, m_BasePlayer.m_PlayfieldPos.y + (int)moveDirection.y].StayPos;
                                MovePlayer = true;
                            }
                    }
                    else //if the Player need to choose a new direction
                    {
                        if (!UIManager.Instance.IsNewDirTextActiv())
                        {
                            needDir = true;
                            UIManager.Instance.SetNewDirText(true);
                            Debug.Log("Choose a new Direction");
                        }
                    }
                }
                else if (MovePoints == 0) //Change Activ Player after all Moves were done
                {
                    moveDirection = new Vector2(); //Reset Move Direction
                    MovePoints = -1; //Reset the Movement Points so the Update will be skipt
                    PlayfieldManager.SetNextPlayerActiv();
                }
        }

        public void SetBasePlayer(int _id)
        {
            m_BasePlayer = DataManager.Instance.GetPlayerData().GetPlayerByID(_id);
        }

        public void SetBasePlayer(BasePlayer _bPlayer)
        {
            m_BasePlayer = _bPlayer;
        }

        public void OnMove(InputValue _value)
        {
            if (PlayfieldManager.m_activPlayer == this && needDir)
            {
                Vector2 tmpMove = _value.Get<Vector2>();
                if (tmpMove == -moveDirection) return;
                moveDirection = tmpMove;
                if (PlayfieldManager.CheckForMove(m_BasePlayer.m_PlayfieldPos, moveDirection)) //If the Input Dir was accepted
                {
                    UIManager.Instance.SetNewDirText(false);
                    needDir = false;
                    destination = GridFieldGenerator.m_Grid.Field[m_BasePlayer.m_PlayfieldPos.x + (int)moveDirection.x, m_BasePlayer.m_PlayfieldPos.y + (int)moveDirection.y].StayPos;
                    MovePlayer = true;
                }
            }
        }

        public void OnAction()
        {
            if (PlayfieldManager.m_activPlayer == this)
            {
                System.Random rnd = new System.Random();
                MovePoints = rnd.Next(9, 15);
                needDir = true;
                Debug.Log("You get a " + MovePoints);
            }
        }
    }
}
