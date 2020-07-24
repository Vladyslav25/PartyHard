using Playfield.Node;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Playfield
{
    public class PlayfieldManager : MonoBehaviour
    {
        static GameObject m_activPlayerObj;
        public static Player m_activPlayer;

        private void Start()
        {
            SetActivPlayer(0);
        }

        private static void SetActivPlayer(int _id)
        {
            m_activPlayerObj = DataManager.Instance.GetPlayerData().GetPlayerByID(_id).m_objRef;
            if (m_activPlayerObj == null) Debug.LogError($"No matching PlayerObj with ID: {_id} was found");
            m_activPlayer = m_activPlayerObj.GetComponent<Player>();
            if (m_activPlayer == null) Debug.LogError($"No matching Player Script with ID: {_id} was found");
        }

        public static void SetNextPlayerActiv()
        {
            if (m_activPlayer.m_BasePlayer.m_Id + 1 < DataManager.Instance.GetPlayerData().PlayerCount)
                SetActivPlayer(m_activPlayer.m_BasePlayer.m_Id + 1);
            else
            {
                SetActivPlayer(0);
                DataManager.Instance.GetPlayfiledData().Round++;
                Debug.Log("NextRound!!!");
            }

            Debug.Log("Its your Turn Player: " + (m_activPlayer.m_BasePlayer.m_Id + 1));
        }

        public static bool MovePlayer(int _id, Vector2 _dir)
        {
            if (DataManager.Instance.GetPlayerData().GetPlayerByID(_id) == m_activPlayer.m_BasePlayer)
            {
                if (CheckForMove(m_activPlayer.m_BasePlayer.m_PlayfieldPos, _dir))
                {
                    m_activPlayer.m_BasePlayer.m_PlayfieldPos += new Vector2Int((int)_dir.x, (int)_dir.y);
                    GridFieldGenerator.SetPlayerObjPos(_id, m_activPlayer.m_BasePlayer.m_PlayfieldPos);
                    return true;
                }
            }
            return false;
        }

        public static bool CheckForMove(Vector2Int _playerPos, Vector2 _dir)
        {
            ENodeType[,] field = DataManager.Instance.GetPlayfiledData().Field;
            switch (_dir.x)
            {
                case 0:
                    break;
                case 1:
                    return GridFieldGenerator.m_Grid.Field[_playerPos.x, _playerPos.y].Right != null;
                case -1:
                    return GridFieldGenerator.m_Grid.Field[_playerPos.x, _playerPos.y].Left != null;
                default:
                    Debug.LogError("The Player Input is not valid: " + _dir);
                    break;
            }

            switch (_dir.y)
            {
                case 0:
                    break;
                case 1:
                    return GridFieldGenerator.m_Grid.Field[_playerPos.x, _playerPos.y].Above != null;
                case -1:
                    return GridFieldGenerator.m_Grid.Field[_playerPos.x, _playerPos.y].Under != null;
                default:
                    Debug.LogError("The Player Input is not valid: " + _dir);
                    break;
            }

            return false; //return false if the switch statments failed
        }

        public static int GetAmountOfNeigbors(Vector2Int _pos)
        {
            ANode node = GridFieldGenerator.m_Grid.Field[_pos.x, _pos.y];
            int output = 0;

            if (node.Above != null) output++;
            if (node.Under != null) output++;
            if (node.Right != null) output++;
            if (node.Left != null) output++;

            return output;
        }
    }
}
