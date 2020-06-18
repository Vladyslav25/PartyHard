﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public int Points { get; private set; }
    public Vector2 Position { get; private set; }

    [SerializeField]
    private float m_movementSpeed = 5f;

    private Rigidbody m_rigidbody;
    private Vector2 m_movementInput;

    private void Awake()
    {
        m_rigidbody = GetComponent<Rigidbody>();
    }

    void Start()
    {
        
    }

    void Update()
    {
        Move();
    }

    public void OnMove(InputValue _inputvalue)
    {
        m_movementInput = _inputvalue.Get<Vector2>();
    }


    public void Move()
    {
        Vector3 direction = m_movementInput.x * transform.right
                         + m_movementInput.y * transform.forward;

        direction = direction.normalized * m_movementSpeed;
        direction.y = m_rigidbody.velocity.y;

        m_rigidbody.velocity = direction;
    }
}
