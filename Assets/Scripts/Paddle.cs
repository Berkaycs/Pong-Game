using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 10.0f;
    protected Rigidbody2D paddleRb;

    private void Awake()
    {
        paddleRb = GetComponent<Rigidbody2D>();
    }

    public void ResetPosition()
    {
        paddleRb.position = new Vector2 (paddleRb.position.x, 0);
        paddleRb.velocity = Vector2.zero;
    }
}
