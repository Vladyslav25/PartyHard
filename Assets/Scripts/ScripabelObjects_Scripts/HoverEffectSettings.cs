using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "HoverEffectSettings", menuName ="Settings/HoverEffect Settings", order = 100)]
public class HoverEffectSettings : ScriptableObject
{
    [Header("Settings")]
    [Tooltip("Speed Up and Down")]
    public float Speed;
    [Tooltip("Muptiplicator for the Up and Down Distance")]
    public float Offset;
}
