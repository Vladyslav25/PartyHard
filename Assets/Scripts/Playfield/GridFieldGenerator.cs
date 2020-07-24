using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.InputSystem;

namespace Playfield
{
    [DefaultExecutionOrder(-1)]
    public class GridFieldGenerator : MonoBehaviour
    {
        #region -Variables-
        [Header("GameObjects")]
        public GameObject Field;

        [Header("Seed Settings")]
        [SerializeField]
        private bool useRandomSeed;
        [SerializeField]
        private string seed;

        [Header("Prefabs")]
        public GameObject[] PlayerPrefab;


        /// <summary>
        /// The Grid-Component in the Field GameObject
        /// </summary>
        public static Grid m_Grid;
        private Vector3[] SpawnPoints = new Vector3[4];

        #endregion

        #region -Unity Functions-
        private void Awake()
        {
            if (useRandomSeed)
                UnityEngine.Random.InitState((int)System.DateTime.Now.Ticks);
            else
                UnityEngine.Random.InitState(seed.GetHashCode());
        }

        private void Start()
        {
            m_Grid = Field.GetComponent<Grid>();
            if (m_Grid == null) Debug.LogError("No Grid in Field found");
            ENodeType[,] tmp_field = new ENodeType[m_Grid.Field.GetLength(0), m_Grid.Field.GetLength(1)];

            if (DataManager.Instance.GetPlayfiledData().Field == null)
            {
                #region -Generate Field-
                bool[,] isoGrid = new bool[m_Grid.Field.GetLength(0), m_Grid.Field.GetLength(1)];

                //Fill a quater of the isoGrid
                for (int x = 0; x < m_Grid.Size.x / 2 + 1; x++)
                {
                    for (int y = 0; y < m_Grid.Size.y / 2 + 1; y++)
                    {
                        isoGrid[x, y] = false;

                        if (x == 0 || y == 0

                            || x == m_Grid.Size.x - 1 || y == m_Grid.Size.y - 1         //Create border
                            || x == m_Grid.Size.x / 2 || y == m_Grid.Size.y / 2 ||      //Create midcross

                            x == m_Grid.Size.x / 4 &&                                     // Create left verticel Side
                            y > m_Grid.Size.y / 4 - 1 && y < m_Grid.Size.y * 3 / 4 + 1 ||   // Need +1 and -1 to get the corner

                            y == m_Grid.Size.y / 4 &&                                     // Create botton horizontal Side
                            x > m_Grid.Size.x / 4 - 1 && x < m_Grid.Size.x * 3 / 4 + 1
                            )
                        {
                            isoGrid[x, y] = true;
                        }
                    }
                }

                bool[,] isoGrid2 = FlipHorizontal(isoGrid);
                bool[,] isoGrid3 = FlipVertical(isoGrid);
                bool[,] isoGrid4 = FlipVertical(isoGrid2);

                for (int x = 0; x < m_Grid.Size.x; x++)
                {
                    for (int y = 0; y < m_Grid.Size.y; y++)
                    {
                        if (isoGrid[x, y] || isoGrid2[x, y] || isoGrid3[x, y] || isoGrid4[x, y])
                            tmp_field[x, y] = (ENodeType)UnityEngine.Random.Range(1, 7);
                    }
                }

                #endregion

                m_Grid.CreatField(tmp_field);

                SpawnPoints[0] = m_Grid.Field[0, 0].StayPos;
                SpawnPoints[1] = m_Grid.Field[0, m_Grid.Size.y - 1].StayPos;
                SpawnPoints[2] = m_Grid.Field[m_Grid.Size.x - 1, 0].StayPos;
                SpawnPoints[3] = m_Grid.Field[m_Grid.Size.x - 1, m_Grid.Size.y - 1].StayPos;
                if (DataManager.Instance.GetPlayerData() != null)
                {
                    LoadPlayer(true);
                }
            }
            else
            {
                m_Grid.CreatField(DataManager.Instance.GetPlayfiledData().Field);

                if (DataManager.Instance.GetPlayerData() != null)
                {
                    LoadPlayer();
                }
            }
        }
        #endregion

        public void LoadPlayer(bool _setOnSpwan = false)
        {
            for (int i = 0; i < DataManager.Instance.GetPlayerData().PlayerCount; i++)
            {
                BasePlayer bPlayerTmp = DataManager.Instance.GetPlayerData().GetPlayerByID(i);
                GameObject obj = null;
                if (_setOnSpwan)
                {
                    //obj = Instantiate(PlayerPrefab[i], SpawnPoints[i], Quaternion.Euler(0, 0, 0));
                    DataManager.Instance.GetPlayerData().GetPlayerByID(i).m_PlayfieldPos = new Vector2Int((int)SpawnPoints[i].x, (int)SpawnPoints[i].z);
                    bPlayerTmp.SetPlayerInput(PlayerInput.Instantiate(PlayerPrefab[i], i, DataManager.Instance.GetPlayerData().GetPlayerByID(i).m_ControlScheme.name));
                    bPlayerTmp.m_objRef.transform.position = SpawnPoints[i];
                }
                else
                {
                    Vector2Int playerPos = DataManager.Instance.GetPlayerData().GetPlayerByID(i).m_PlayfieldPos;
                    //obj = Instantiate(PlayerPrefab[i], m_Grid.Field[playerPos.x, playerPos.y].StayPos, Quaternion.Euler(0, 0, 0));
                    bPlayerTmp.SetPlayerInput(PlayerInput.Instantiate(PlayerPrefab[i], i, DataManager.Instance.GetPlayerData().GetPlayerByID(i).m_ControlScheme.name));
                    bPlayerTmp.m_objRef.transform.position = m_Grid.Field[playerPos.x, playerPos.y].StayPos;
                }

                bPlayerTmp.m_objRef.GetComponent<Player>().SetBasePlayer(bPlayerTmp);
            }
        }

        private bool[,] FlipHorizontal(bool[,] _arrayToFlip)
        {
            int rows = _arrayToFlip.GetLength(0);
            int columms = _arrayToFlip.GetLength(1);
            bool[,] output = new bool[_arrayToFlip.GetLength(0), _arrayToFlip.GetLength(1)];

            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columms; y++)
                {
                    output[x, y] = _arrayToFlip[(rows - 1) - x, y];
                }
            }

            return output;
        }

        private bool[,] FlipVertical(bool[,] _arrayToFlip)
        {
            int rows = _arrayToFlip.GetLength(0);
            int columms = _arrayToFlip.GetLength(1);
            bool[,] output = new bool[_arrayToFlip.GetLength(0), _arrayToFlip.GetLength(1)];

            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columms; y++)
                {
                    output[x, y] = _arrayToFlip[x, (columms - 1) - y];
                }
            }

            return output;
        }

        public static void SetPlayerObjPos(int _id, Vector2Int _newPos)
        {
            DataManager.Instance.GetPlayerData().GetPlayerByID(_id).m_objRef.transform.position = m_Grid.Field[_newPos.x, _newPos.y].StayPos;
        }
    }
}