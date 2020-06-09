using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "HoverEffectSettings", menuName ="Settings/HoverEffect Settings", order = 100)]
public class HoverEffectSettings : ScriptableObject
{
    public float Speed;
    public float Offset;
}
