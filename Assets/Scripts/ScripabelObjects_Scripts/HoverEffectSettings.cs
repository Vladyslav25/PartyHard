using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "HoverEffectSettings", menuName ="ScObj/Settings/HoverEffect Settings", order = 1)]
public class HoverEffectSettings : ScriptableObject
{
    [Header("Settings")]
    [Tooltip("Speed Up and Down")]
    public float Speed;
    [Tooltip("Muptiplicator for the Up and Down Distance")]
    public float Offset;
}
