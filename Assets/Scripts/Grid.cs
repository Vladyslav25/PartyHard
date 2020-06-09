using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Playfield.Node;

public class Grid : MonoBehaviour
{
    public ANode[,] Field;
    [Header("Map")]
    public Vector2Int Size;
    [Header("Settings")]
    public HoverEffectSettings GridSetting;

    public void Awake()
    {
        Field = new ANode[Size.x, Size.y];
    }
}
