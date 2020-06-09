using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverEffect : MonoBehaviour
{
    private float speed;
    private float offset;

    private float x;
    private float rnd_offset;

    private void Awake()
    {
        rnd_offset = UnityEngine.Random.Range(0, 8);
    }

    void Update()
    {
        x += Time.deltaTime * speed;
        //Set new Position with the bigger x value
        transform.position = new Vector3(transform.position.x, Mathf.Sin(x + rnd_offset) * offset, transform.position.z); 
    }

    #region -Custom Functions-
    /// <summary>
    /// Set a new Speed for the Node
    /// </summary>
    /// <param name="_newSpeed">The new Speed</param>
    public void SetSpeed(float _newSpeed)
    {
        speed = _newSpeed;
    }

    /// <summary>
    /// Set a new Offset for the Node
    /// </summary>
    /// <param name="_newOffset">The new Offset for the Node</param>
    public void SetOffset(float _newOffset)
    {
        offset = _newOffset;
    }

    /// <summary>
    /// Set new Settings for the Node
    /// </summary>
    /// <param name="_newSpeed">The new Speed for the Node</param>
    /// <param name="_newOffset">The new Offset for the Node</param>
    public void SetSettings(float _newSpeed, float _newOffset)
    {
        speed = _newSpeed;
        offset = _newOffset;
    }

    /// <summary>
    /// Set new Settings for the Node
    /// </summary>
    /// <param name="_gridSetting">The new Settings for the Node</param>
    public void SetSettings(HoverEffectSettings _gridSetting)
    {
        speed = _gridSetting.Speed;
        offset = _gridSetting.Offset;
    }
    #endregion
}
