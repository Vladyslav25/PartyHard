using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Playfield
{
    public class GridFiledGenerator : MonoBehaviour
    {
        #region -Variables-
        [Header("GameObjects")]
        public GameObject Field;

        /// <summary>
        /// The Grid-Component in the Field GameObject
        /// </summary>
        private Grid grid;

        private int rnd_int;
        #endregion

        #region -Unity Functions-
        void Start()
        {
            grid = Field.GetComponent<Grid>();
            ENodeType[,] tmp_field = new ENodeType[grid.Field.GetLength(0), grid.Field.GetLength(1)];
            #region -TODO: Generate Map-
            for (int x = 0; x < grid.Size.x; x++)
            {
                for (int y = 0; y < grid.Size.y; y++)
                {
                    if (x == 0 || y == 0

                        || x == grid.Size.x - 1 || y == grid.Size.y - 1      //Create border
                        || x == grid.Size.x / 2 || y == grid.Size.y / 2 ||     //Create midcross

                        x == grid.Size.x / 4 + 1 &&
                        y > grid.Size.y / 4 && y < grid.Size.y * 3 / 4 ||

                        x == grid.Size.x * 3 / 4 - 1 &&
                        y > grid.Size.y / 4 && y < grid.Size.y * 3 / 4 ||

                        y == grid.Size.y / 4 + 1 &&
                        x > grid.Size.x / 4 && x < grid.Size.x * 3 / 4 ||

                        y == grid.Size.y * 3 / 4 - 1 &&
                        x > grid.Size.x / 4 && x < grid.Size.x * 3 / 4)

                        tmp_field[x, y] = (ENodeType)Random.Range(1, 7);
                }
            }
            #endregion
            grid.CreatField(tmp_field);
        }
        #endregion
    }
}