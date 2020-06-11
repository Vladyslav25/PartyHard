﻿using System.Collections;
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
                    //Fill the Field with Random Nodes
                    rnd_int = Random.Range(0, 7);
                    ENodeType type = (ENodeType)rnd_int;

                    tmp_field[x, y] = type;
                }
            }
            #endregion
            grid.CreatField(tmp_field);
        }
        #endregion

        #region -Custom private Functions-




        #endregion
    }
}