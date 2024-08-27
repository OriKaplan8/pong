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

    protected void FixedUpdate()
    {
        if (moveDirection == Vector2.zero)
        {
            _rigidbody.velocity = Vector2.zero;
        }
        else
        {
            _rigidbody.velocity = new Vector2(0, moveSpeed * moveDirection.y);
        }
    }
    
}
