using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    private Rigidbody2D ballRb;
    private GameManager gameManager;
    
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        ballRb = GetComponent<Rigidbody2D>();
        Move();
    }

    // Update is called once per frame
    void Update()
    {
        GameState();
    }

    public void Move()
    {
        float speed = Random.Range(25,30);
        int choice = Random.Range(1, 3);

        if (choice == 1) 
        {
            ballRb.AddForce(Vector2.left * speed, ForceMode2D.Impulse);
        }
        else if (choice == 2)
        {
            ballRb.AddForce(Vector2.right * speed, ForceMode2D.Impulse);
        }
    }
    // Is game continue?
    public void GameState()
    {
        if (gameManager.score_1 == 10 | gameManager.score_2 == 10)
        {
            gameManager.gameOver = true;
        }
        else
        {
            gameManager.gameOver = false;
        }
    }

    // Score system
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("leftTrigger"))
        {
            gameManager.addScore_1(1);
            gameManager.score1.text = "Score: " + gameManager.score_1;
            gameManager.isBallSpawned = false;
        }

        if (collision.CompareTag("rightTrigger"))
        {
            gameManager.addScore_2(1);
            gameManager.score2.text = "Score: " + gameManager.score_2;
            gameManager.isBallSpawned = false;
        }
    }
}
