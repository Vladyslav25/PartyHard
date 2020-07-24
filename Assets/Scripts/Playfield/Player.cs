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

        private int numberOfPoints;
        Vector2 move;

        public int Points { get; private set; }

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
                if (tmpMove == -move) return;
                move = tmpMove;
                needDir = false;
                PlayfieldManager.MovePlayer(m_BasePlayer.m_Id, move);
                numberOfPoints--;
                Move();
            }
        }

        public void OnAction()
        {
            if (PlayfieldManager.m_activPlayer == this)
            {
                System.Random rnd = new System.Random();
                numberOfPoints = rnd.Next(9, 15);
                needDir = true;
                Debug.Log("You get a " + numberOfPoints);
            }
        }

        private void Move()
        {
            int MaxTurns = numberOfPoints;
            for (int i = 0; i < MaxTurns; i++)
            {
                if (PlayfieldManager.GetAmountOfNeigbors(m_BasePlayer.m_PlayfieldPos) == 2)
                {
                    if (PlayfieldManager.MovePlayer(m_BasePlayer.m_Id, move))
                    {
                        numberOfPoints--;
                    }
                    else
                    {
                        Vector2 toCheck = new Vector2();
                        switch (move.x)
                        {
                            case 0:
                                break;
                            case 1:
                            case -1:
                                toCheck = new Vector2(0, 1);
                                break;
                        }
                        switch (move.y)
                        {
                            case 0:
                                break;
                            case 1:
                            case -1:
                                toCheck = new Vector2(1, 0);
                                break;
                        }

                        if (PlayfieldManager.CheckForMove(m_BasePlayer.m_PlayfieldPos, toCheck))
                            move = toCheck;
                        else if(PlayfieldManager.CheckForMove(m_BasePlayer.m_PlayfieldPos, -toCheck))
                            move = -toCheck;

                        if (PlayfieldManager.MovePlayer(m_BasePlayer.m_Id, move))
                        {
                            numberOfPoints--;
                        }
                    }
                }
                else
                {
                    needDir = true;
                    Debug.Log("Choose a new Direction");
                    return;
                }
            }

            if (numberOfPoints == 0)
            {
                PlayfieldManager.SetNextPlayerActiv();
                move = new Vector2();
            }
            else
            {
                Debug.LogError("SoftLock: Not all Turns have been played.");
            }
        }
    }
}
