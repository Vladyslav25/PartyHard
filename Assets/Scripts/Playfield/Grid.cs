using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Playfield.Node;
using System.Drawing;
using UnityEngine.SceneManagement;

namespace Playfield
{
    public enum ENodeType
    {
        NONE,
        RED,
        BLUE,
        YELLOW,
        GREEN,
        BLACK,
        WHITE
    }

    public class Grid : MonoBehaviour
    {
        public ANode[,] Field; //For Gameplay

        private ENodeType[,] EField; //For Save and Load
        [HideInInspector]
        public Vector2Int Size;

        [Header("Field")]
        [Range(11,31)]
        [SerializeField]
        private int sizeHorizontal;
        [Range(11,31)]
        [SerializeField]
        private int sizeVertical;
        public List<GameObject> NodePrefabs;
        [Header("Settings")]
        public HoverEffectSettings GridSetting;

        private float timer;

        public void Awake()
        {
            Size = new Vector2Int(sizeHorizontal, sizeVertical);
            // Adjust the Size for the Generator
            if (Size.x < 11) Size.x = 11;

            if (Size.y < 11) Size.y = 11;

            if (Size.x % 2 == 0) Size.x++;

            if (Size.y % 2 == 0) Size.y++;

            //Set Arrays
            Field = new ANode[Size.x, Size.y];
            EField = new ENodeType[Size.x, Size.y];
        }

        /// <summary>
        /// Set the Neighbors of the Nodes
        /// </summary>
        private void SetNeighbors()
        {
            for (int x = 0; x < Field.GetLength(0); x++)
            {
                for (int y = 0; y < Field.GetLength(1); y++)
                {
                    if (Field[x, y] == null) continue;                                         //if there is no Node on this Position

                    if (!(x + 1 > Field.GetLength(0) - 1) && (Field[x + 1, y] != null))   //if the right Node is inside Range and
                        Field[x, y].Right = Field[x + 1, y];                                  //if it exist
                    if (!(x - 1 < 0) && (Field[x - 1, y] != null))                             //if the left Node is inside Range and
                        Field[x, y].Left = Field[x - 1, y];                                   //if it exist
                    if (!(y + 1 > Field.GetLength(1) - 1) && (Field[x, y + 1] != null))   //if the Above Node is in Range and
                        Field[x, y].Above = Field[x, y + 1];                                  //if it exist
                    if (!(y - 1 < 0) && (Field[x, y - 1] != null))                             // if the Under Node is in Range and
                        Field[x, y].Under = Field[x, y - 1];                                  //if it exist
                }
            }
        }

        /// <summary>
        /// Print the neighbor of each Node
        /// </summary>
        private void PrintNeighbor()
        {
            foreach (ANode n in Field)
            {
                if (n == null) continue;
                n.PrintNeighbor();
            }
        }

        /// <summary>
        /// Create a Node
        /// </summary>
        /// <param name="_type">The Type of the Node</param>
        /// <param name="_pos">The Position of the Node in Word and Index</param>
        private void CreateNode(ENodeType _type, Vector3 _pos)
        {
            ANode toAdd = null;
            GameObject tmp = null;
            int index = -1;

            switch (_type)
            {
                case ENodeType.NONE:
                    index = 0;
                    break;
                case ENodeType.RED:
                    toAdd = new RedNode(_pos, this);
                    index = 1;
                    break;
                case ENodeType.BLUE:
                    toAdd = new BlueNode(_pos, this);
                    index = 2;
                    break;
                case ENodeType.YELLOW:
                    toAdd = new YellowNode(_pos, this);
                    index = 3;
                    break;
                case ENodeType.BLACK:
                    toAdd = new BlackNode(_pos, this);
                    index = 4;
                    break;
                case ENodeType.WHITE:
                    toAdd = new WhiteNode(_pos, this);
                    index = 5;
                    break;
                case ENodeType.GREEN:
                    toAdd = new GreenNode(_pos, this);
                    index = 6;
                    break;
                default:
                    break;
            }

            if (index > 0)
            {
                tmp = Instantiate(NodePrefabs[index], _pos, new Quaternion(0, 0, 0, 0), this.transform);    // Add in World
                toAdd.SetObjectRef(tmp);
            }

            EField[(int)_pos.x, (int)_pos.z] = _type;   // Add in Code
            Field[(int)_pos.x, (int)_pos.z] = toAdd;    // Add in Code
        }

        /// <summary>
        /// Create the Playfield
        /// </summary>
        /// <param name="_field">An EGridType 2D Array with the Field</param>
        public void CreatField(ENodeType[,] _field)
        {
            for (int x = 0; x < _field.GetLength(0); x++)
            {
                for (int y = 0; y < _field.GetLength(1); y++)
                {
                    CreateNode(_field[x, y], new Vector3(x, 0, y));
                }
            }
            SetNeighbors();
            Save();
        }

        public void Save()
        {
            DataManager.Instance.GetPlayfiledData().Field = EField;
        }

        public void Load()
        {
            CreatField(DataManager.Instance.GetPlayfiledData().Field);
        }
    }
}
