using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    private Rigidbody2D ballRb;
    private GameManager gameManager;
    public AudioSource source;
    public AudioClip scoreSound, hitSound;
    
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        ballRb = GetComponent<Rigidbody2D>();
        ResetPosition();
        StartCoroutine(Wait());
        Move();
    }

    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(5);
    }

    public void Move()
    {
        float speed = 4.5f;
        int choice = Random.Range(1, 3);
        
        float randomX1 = Random.Range(-5, -1);
        float randomX2 = Random.Range(1, 5);
        float randomY = Random.Range(-4, 4);

        if (choice == 1)
        {
            Vector2 direction = new Vector2(randomX1, randomY);
            ballRb.AddForce(direction * speed, ForceMode2D.Impulse);
        }
        else if (choice == 2)
        {
            Vector2 direction = new Vector2(randomX2, randomY);
            ballRb.AddForce(direction * speed, ForceMode2D.Impulse);
        }
        

        /*
        if (choice == 1) 
        {
            ballRb.gravityScale = 1;
            ballRb.AddForce(Vector2.left * speed, ForceMode2D.Impulse);
        }
        else if (choice == 2)
        {
            ballRb.gravityScale = 1;
            ballRb.AddForce(Vector2.right * speed, ForceMode2D.Impulse);
        }
        else if (choice == 3)
        {
            ballRb.gravityScale = -0.1f;
            ballRb.AddForce(Vector2.left * speed, ForceMode2D.Impulse);
        }
        else if (choice == 4)
        {
            ballRb.gravityScale = -0.1f;
            ballRb.AddForce(Vector2.right * speed, ForceMode2D.Impulse);
        }
        */
    }

    public void ResetPosition()
    {
        ballRb.position = Vector2.zero;
        ballRb.velocity = Vector2.zero;
    }

    public void AddForce(Vector2 force)
    {
        ballRb.AddForce(force);
    }

    public void HitSound()
    {
        source.clip = hitSound;
        source.Play();
    }

    public void ScoreSound()
    {
        source.clip = scoreSound;
        source.Play();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Board"))
        {
            HitSound();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("leftTrigger"))
        {
            ScoreSound();
            gameManager.PlayerScores();
        }

        if (collision.CompareTag("rightTrigger"))
        {
            ScoreSound();
            gameManager.ComputerScores();
        }
    }
    
}
