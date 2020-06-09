using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEditor;
using UnityEngine;

namespace Playfield.Node
{
    public abstract class ANode
    {
        //Neighbors 
        public ANode Above = null;
        public ANode Under = null;
        public ANode Left = null;
        public ANode Right = null;

        //Referenc to the Node GamObject
        public GameObject obj { get; private set; }

        //Position in World
        public Vector3 Pos;

        //Referenc to the Grid
        private Grid m_grid;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="_pos">The Position in the Grid and World</param>
        /// <param name="_grid">Referenc to the Grid</param>
        /// <param name="_obj">Referenc to the GameObject</param>
        public ANode(Vector3 _pos, Grid _grid, GameObject _obj = null)
        {
            Pos = _pos;
            m_grid = _grid;
            obj = _obj;

            if (_obj != null)
            {
                //Set Hover Effect Settings
                HoverEffect HE = obj.transform.GetComponentInChildren<HoverEffect>();
                if (HE != null)
                {
                    HE.SetSettings(m_grid.GridSetting);
                }
            }
        }

        /// <summary>
        /// Set the Referenc of the GameObject
        /// </summary>
        /// <param name="_obj">Referenc to the GameObject</param>
        public virtual void SetObjectRef(GameObject _obj)
        {
            obj = _obj;
        }

        /// <summary>
        /// Trigger the Event on the Node
        /// </summary>
        /// <param name="_player">The Player that trigger the Node</param>
        public abstract void Execute(Player _player);

        /// <summary>
        /// DEBUG -> Print all Neighbors in the Log
        /// </summary>
        public virtual void PrintNeighbor()
        {
            string output = "";
            if(Above != null)
            {
                output += $" | Above: {Above.Pos}";
            }
            if (Under != null)
            {
                output += $" | Under: {Under.Pos}";
            }
            if (Right != null)
            {
                output += $" | Right: {Right.Pos}";
            }
            if (Left != null)
            {
                output += $" | Left: {Left.Pos}";
            }
            Debug.Log($"Pos: {Pos}{output}");
        }
    }
}
