using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Playfield
{
    public class GridFieldGenerator : MonoBehaviour
    {
        #region -Variables-
        [Header("GameObjects")]
        public GameObject Field;

        /// <summary>
        /// The Grid-Component in the Field GameObject
        /// </summary>
        private Grid grid;

        #endregion

        #region -Unity Functions-
        void Start()
        {
            grid = Field.GetComponent<Grid>();
            ENodeType[,] tmp_field = new ENodeType[grid.Field.GetLength(0), grid.Field.GetLength(1)];

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
        }
        #endregion

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