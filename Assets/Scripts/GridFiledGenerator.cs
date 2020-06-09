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
        public GameObject Field;
        public GameObject RedNodePrefab;
        public GameObject BlueNodePrefab;
        public GameObject YellowNodePrefab;
        public GameObject GreenNodePrefab;
        public GameObject BlackNodePrefab;
        public GameObject WhiteNodePrefab;

        private Grid Grid;

        private int rnd_int;

        void Start()
        {
            Grid = Field.GetComponent<Grid>();
            for (int x = 0; x < Grid.Size.x; x++)
            {
                for (int y = 0; y < Grid.Size.y; y++)
                {
                    rnd_int = Random.Range(0, 7);
                    EGridType type = (EGridType)rnd_int;

                    Grid.Field[x, y] = CreateNode(type, new Vector3(x, 0, y));
                }
            }
            SetNeighbors();
            //PrintNeighbor();
        }

        private void SetNeighbors()
        {
            for (int x = 0; x < Grid.Field.GetLength(0); x++)
            {
                for (int y = 0; y < Grid.Field.GetLength(1); y++)
                {
                    if (Grid.Field[x, y] == null) continue;
                    if (!(x + 1 > Grid.Field.GetLength(0) - 1) && (Grid.Field[x + 1, y] != null))
                        Grid.Field[x, y].Right = Grid.Field[x + 1, y];
                    if (!(x - 1 < 0) && (Grid.Field[x - 1, y] != null))
                        Grid.Field[x, y].Left = Grid.Field[x - 1, y];
                    if (!(y + 1 > Grid.Field.GetLength(1) - 1) && (Grid.Field[x, y + 1] != null))
                        Grid.Field[x, y].Above = Grid.Field[x, y + 1];
                    if (!(y - 1 < 0) && (Grid.Field[x, y - 1] != null))
                        Grid.Field[x, y].Under = Grid.Field[x, y - 1];
                }
            }
        }

        private void PrintNeighbor()
        {
            foreach (ANode n in Grid.Field)
            {
                if (n == null) continue;
                n.PrintNeighbor();
            }
        }

        private ANode CreateNode(EGridType _type, Vector3 _pos)
        {
            ANode toAdd = null;
            GameObject tmp = null;
            switch (_type)
            {
                case EGridType.NONE:
                    break;
                case EGridType.RED:
                    tmp = Instantiate(RedNodePrefab, _pos, new Quaternion(0, 0, 0, 0), Field.transform);
                    toAdd = new RedNode(_pos, Grid, tmp);
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
    }
}
