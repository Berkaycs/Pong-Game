using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Paddle : Paddle
{
    private Vector2 direction;

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            direction = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            direction = Vector2.down;
        }
        else
        {
            direction = Vector2.zero;
        }
    }
    // Physic related logic
    private void FixedUpdate()
    {
        // as long as not equal 0 it shows us that we are moving in direction
        if (direction.sqrMagnitude != 0)
        {
            paddleRb.AddForce(direction * this.speed);
        }
    }
}
