using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerPaddle : Paddle
{
    public Rigidbody2D ball;

    private void FixedUpdate()
    {
        // if ball moves to the computer paddle's area
        if (this.ball.velocity.x < 0)
        {
            // if computer paddle is below the ball, move computer paddle to up
            if (this.ball.position.y > this.transform.position.y)
            {
                paddleRb.AddForce(Vector2.up * this.speed);
            }
            // if computer paddle is on top the ball, move computer paddle to down
            else if (this.ball.position.y < this.transform.position.y)
            {
                paddleRb.AddForce(Vector2.down * this.speed);
            }

        }
        // if ball moves to the computer paddle's towards area, make it move naturally it shouldn't stay just like that
        else
        {
            if (this.transform.position.y > 0.0f)
            {
                paddleRb.AddForce(Vector2.down * this.speed);
            }
            else if (this.transform.position.y < 0.0f)
            {
                paddleRb.AddForce(Vector2.up * this.speed);
            }
        }
    }
}
