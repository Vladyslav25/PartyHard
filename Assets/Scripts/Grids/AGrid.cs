using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public abstract class AGrid : MonoBehaviour
{
    public AGrid Above;
    public AGrid Under;
    public AGrid Left;
    public AGrid Right;

    public abstract void Execute();
}
