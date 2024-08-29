using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerPaddle : Paddle
{

    private void Update()
    {
        moveDirection = Vector2.zero;

        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            moveDirection = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            moveDirection = Vector2.down;
        }

    }

    private void FixedUpdate()
    {
        // Apply movement based on the current moveDirection
        if (moveDirection == Vector2.zero)
        {
            _rigidbody.velocity = Vector2.zero;
        }
        else
        {
            _rigidbody.velocity = new Vector2(0, moveDirection.y * moveSpeed);
        }
    }




}
