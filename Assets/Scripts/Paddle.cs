using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    protected Rigidbody2D _rigidbody;
    public float moveSpeed = 5f;
    protected Vector2 moveDirection = Vector2.zero;

    protected void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }


    

}
