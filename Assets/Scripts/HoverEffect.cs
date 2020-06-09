using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverEffect : MonoBehaviour
{
    public float Speed;
    public float Offset;

    private float x;
    private float rnd_offset;

    private void Awake()
    {
        rnd_offset = Random.Range(0, 8);
    }

    // Update is called once per frame
    void Update()
    {
        x += Time.deltaTime * Speed;
        transform.position = new Vector3(transform.position.x, Mathf.Sin(x + rnd_offset) * Offset, transform.position.z);
    }
}
