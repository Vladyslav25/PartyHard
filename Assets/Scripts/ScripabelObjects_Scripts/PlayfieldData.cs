using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Playfield;
using System.Drawing;

[CreateAssetMenu(fileName = "Playfield Data", menuName = "ScObj/Data/Playfield", order = 1)]
public class PlayfieldData : ScriptableObject
{
    public ENodeType[,] Field;
    public Dictionary<BasePlayer, Vector2> PlayerPos = new Dictionary<BasePlayer, Vector2>();

    public void PrintDebug()
    {
        Debug.Log(Field.GetLength(0));
        Debug.Log(Field.GetLength(1));
    }
}
