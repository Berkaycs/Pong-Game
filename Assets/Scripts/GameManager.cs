using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public MoveBall ball;
    public Win player;
    public Win computer;
    public GameOverScreen gameOverScreen;
    private AudioSource winSound;

    // Score display
    public TextMeshProUGUI playerScoreText;
    public TextMeshProUGUI computerScoreText;
    private int player_score = 0;
    private int computer_score = 0;

    public Paddle playerPaddle;
    public Paddle computerPaddle;


    void Start()
    {
        winSound = GetComponent<AudioSource>();
        playerScoreText.text = "Score: " + player_score;
        computerScoreText.text = "Score: " + computer_score;
    }

    public void PlayerScores()
    {
        player_score++;
        playerScoreText.text = "Score: " + player_score;
        if (player_score < 10)
        {
            ResetRound();
        }
        else
        {
            player.WinText();
            winSound.Play();
            // wait 3 seconds than call
            gameOverScreen.Invoke("GameOver", 3);
        }
        
    }

    public void ComputerScores()
    {
        computer_score++;
        computerScoreText.text = "Score: " + computer_score;
        if (computer_score < 10)
        {
            ResetRound();
        }
        else
        {
            computer.WinText();
            winSound.Play();
            // wait 3 seconds than call
            gameOverScreen.Invoke("GameOver", 3);
        }
    }

    private void ResetRound()
    {
        this.ball.ResetPosition();
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
        this.ball.Move();
    }
}
