using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverEffect : MonoBehaviour
{
    private HoverEffectSettings setting;

    private float x;
    private float rnd_offset;

    private void OnEnable()
    {
        rnd_offset = UnityEngine.Random.Range(0, 8);
        setting = DataManager.Instance.GetHoverEffectSettings();
    }

    private void Update()
    {
        x += Time.deltaTime * setting.Speed;

        //Set new Position with the bigger x value
        transform.position = new Vector3(transform.position.x, Mathf.Sin(x + rnd_offset) * setting.Offset, transform.position.z); 
    }
}
