using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Playfield.Node;

public enum EGridType
{
    NONE,
    RED,
    BLUE,
    YELLOW,
    GREEN,
    BLACK,
    WHITE
}

namespace Playfield
{
    public class GridFiledGenerator : MonoBehaviour
    {
        #region -Variables-
        [Header("GameObjects")]
        public GameObject Field;
        [Header("Prefabs")]
        public GameObject RedNodePrefab;
        public GameObject BlueNodePrefab;
        public GameObject YellowNodePrefab;
        public GameObject GreenNodePrefab;
        public GameObject BlackNodePrefab;
        public GameObject WhiteNodePrefab;

        /// <summary>
        /// The Grid-Component in the Field GameObject
        /// </summary>
        private Grid Grid; 

        private int rnd_int;
        #endregion

        #region -Unity Functions-
        void Start()
        {
            Grid = Field.GetComponent<Grid>();
            #region -TODO: Generate Map-
            for (int x = 0; x < Grid.Size.x; x++)
            {
                for (int y = 0; y < Grid.Size.y; y++)
                {
                    //Fill the Field with Random Nodes
                    rnd_int = Random.Range(0, 7);
                    EGridType type = (EGridType)rnd_int;

                    Grid.Field[x, y] = CreateNode(type, new Vector3(x, 0, y));
                }
            }
            #endregion
            SetNeighbors();
            //PrintNeighbor();
        }
        #endregion

        #region -Custom private Functions-
        /// <summary>
        /// Set the Neighbors of the Nodes
        /// </summary>
        private void SetNeighbors()
        {
            for (int x = 0; x < Grid.Field.GetLength(0); x++)
            {
                for (int y = 0; y < Grid.Field.GetLength(1); y++)
                {
                    if (Grid.Field[x, y] == null) continue;                                         //if there is no Node on this Position

                    if (!(x + 1 > Grid.Field.GetLength(0) - 1) && (Grid.Field[x + 1, y] != null))   //if the right Node is inside Range and
                        Grid.Field[x, y].Right = Grid.Field[x + 1, y];                                  //if it exist
                    if (!(x - 1 < 0) && (Grid.Field[x - 1, y] != null))                             //if the left Node is inside Range and
                        Grid.Field[x, y].Left = Grid.Field[x - 1, y];                                   //if it exist
                    if (!(y + 1 > Grid.Field.GetLength(1) - 1) && (Grid.Field[x, y + 1] != null))   //if the Above Node is in Range and
                        Grid.Field[x, y].Above = Grid.Field[x, y + 1];                                  //if it exist
                    if (!(y - 1 < 0) && (Grid.Field[x, y - 1] != null))                             // if the Under Node is in Range and
                        Grid.Field[x, y].Under = Grid.Field[x, y - 1];                                  //if it exist
                }
            }
        }

        /// <summary>
        /// Print the neighbor of each Node
        /// </summary>
        private void PrintNeighbor()
        {
            foreach (ANode n in Grid.Field)
            {
                if (n == null) continue;
                n.PrintNeighbor();
            }
        }

        /// <summary>
        /// Create a Node
        /// </summary>
        /// <param name="_type">The Type of the Node</param>
        /// <param name="_pos">The Position of the Node</param>
        /// <returns>The created Node</returns>
        private ANode CreateNode(EGridType _type, Vector3 _pos)
        {
            ANode toAdd = null;
            GameObject tmp = null;
            switch (_type)
            {
                case EGridType.NONE:
                    break;
                case EGridType.RED:
                    tmp = Instantiate(RedNodePrefab, _pos, new Quaternion(0, 0, 0, 0), Field.transform);    // Add in Unity
                    toAdd = new RedNode(_pos, Grid, tmp);                                                   // Add in Code
                    break;
                case EGridType.BLUE:
                    tmp = Instantiate(BlueNodePrefab, _pos, new Quaternion(0, 0, 0, 0), Field.transform);
                    toAdd = new BlueNode(_pos, Grid, tmp);
                    break;
                case EGridType.YELLOW:
                    tmp = Instantiate(YellowNodePrefab, _pos, new Quaternion(0, 0, 0, 0), Field.transform);
                    toAdd = new YellowNode(_pos, Grid, tmp);
                    break;
                case EGridType.BLACK:
                    tmp = Instantiate(BlackNodePrefab, _pos, new Quaternion(0, 0, 0, 0), Field.transform);
                    toAdd = new BlackNode(_pos, Grid, tmp);
                    break;
                case EGridType.WHITE:
                    tmp = Instantiate(WhiteNodePrefab, _pos, new Quaternion(0, 0, 0, 0), Field.transform);
                    toAdd = new WhiteNode(_pos, Grid, tmp);
                    break;
                case EGridType.GREEN:
                    tmp = Instantiate(GreenNodePrefab, _pos, new Quaternion(0, 0, 0, 0), Field.transform);
                    toAdd = new GreenNode(_pos, Grid, tmp);
                    break;
                default:
                    break;
            }
            return toAdd;
        }
        #endregion
    }
}