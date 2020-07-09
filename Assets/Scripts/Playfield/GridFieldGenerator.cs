using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        private Grid grid;
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

        void Start()
        {
            grid = Field.GetComponent<Grid>();
            ENodeType[,] tmp_field = new ENodeType[grid.Field.GetLength(0), grid.Field.GetLength(1)];

            if (DataManager.Instance.GetPlayfiledData().Field == null)
            {
                #region -Generate Field-
                bool[,] isoGrid = new bool[grid.Field.GetLength(0), grid.Field.GetLength(1)];

                //Fill a quater of the isoGrid
                for (int x = 0; x < grid.Size.x / 2 + 1; x++)
                {
                    for (int y = 0; y < grid.Size.y / 2 + 1; y++)
                    {
                        isoGrid[x, y] = false;

                        if (x == 0 || y == 0

                            || x == grid.Size.x - 1 || y == grid.Size.y - 1         //Create border
                            || x == grid.Size.x / 2 || y == grid.Size.y / 2 ||      //Create midcross

                            x == grid.Size.x / 4 &&                                     // Create left verticel Side
                            y > grid.Size.y / 4 - 1 && y < grid.Size.y * 3 / 4 + 1 ||   // Need +1 and -1 to get the corner

                            y == grid.Size.y / 4 &&                                     // Create botton horizontal Side
                            x > grid.Size.x / 4 - 1 && x < grid.Size.x * 3 / 4 + 1
                            )
                        {
                            isoGrid[x, y] = true;
                        }
                    }
                }

                bool[,] isoGrid2 = FlipHorizontal(isoGrid);
                bool[,] isoGrid3 = FlipVertical(isoGrid);
                bool[,] isoGrid4 = FlipVertical(isoGrid2);

                for (int x = 0; x < grid.Size.x; x++)
                {
                    for (int y = 0; y < grid.Size.y; y++)
                    {
                        if (isoGrid[x, y] || isoGrid2[x, y] || isoGrid3[x, y] || isoGrid4[x, y])
                            tmp_field[x, y] = (ENodeType)UnityEngine.Random.Range(1, 7);
                    }
                }

                #endregion

                grid.CreatField(tmp_field);

                Vector3 offset = Vector3.up * 3f;

                SpawnPoints[0] = offset + grid.Field[0, 0].Pos;
                SpawnPoints[1] = offset + grid.Field[0, grid.Size.y - 1].Pos;
                SpawnPoints[2] = offset + grid.Field[grid.Size.x - 1, 0].Pos;
                SpawnPoints[3] = offset + grid.Field[grid.Size.x - 1, grid.Size.y - 1].Pos;
                if (DataManager.Instance.GetPlayerData() != null)
                {
                    LoadPlayer(true);
                }
            }
            else
            {
                grid.CreatField(DataManager.Instance.GetPlayfiledData().Field);

                if (DataManager.Instance.GetPlayerData() != null)
                {
                    LoadPlayer();
                }
            }
        }
        #endregion

        private void LoadPlayer(bool _setOnSpwan = false)
        {
            for (int i = 0; i < DataManager.Instance.GetPlayerData().PlayerCount; i++)
            {
                BasePlayer bPlayerTmp = DataManager.Instance.GetPlayerData().GetPlayerByID(i);
                GameObject obj;
                if (_setOnSpwan)
                    obj = Instantiate(PlayerPrefab[i], SpawnPoints[i], Quaternion.Euler(0, 0, 0));
                else
                    obj = Instantiate(PlayerPrefab[i], DataManager.Instance.GetPlayerData().GetPlayerByID(i).m_PlayfieldPos, Quaternion.Euler(0, 0, 0));

                bPlayerTmp.SetGameObjectRef(obj);
                obj.GetComponent<Playfield.Player>().m_BasePlayer = bPlayerTmp;
                bPlayerTmp.SetInputControlScheme(bPlayerTmp.m_ControlScheme.name);
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
    }
}