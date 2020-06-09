using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Playfield.Node;

public class Grid : MonoBehaviour
{
    public ANode[,] Field;
    public Vector2Int Size;

    public HoverEffectSettings GridSetting;

    public void Awake()
    {
        Field = new ANode[Size.x, Size.y];
    }
}
