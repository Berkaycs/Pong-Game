using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool gameOver = false;
    public bool isBallSpawned = false;

    // Score display
    public TextMeshProUGUI score1;
    public TextMeshProUGUI score2;
    public int score_1 = 0;
    public int score_2 = 0;

    
    void Start()
    {
        score_1 = 0;
        score_2 = 0;
        score1 = GameObject.Find("Score_1").GetComponent<TextMeshProUGUI>();
        score2 = GameObject.Find("Score_2").GetComponent<TextMeshProUGUI>();
        score1.text = "Score: " + score_1;
        score2.text = "Score: " + score_2;
    }

    
    void Update()
    {

    }

    public void addScore_1(int point)
    {
        score_1 += point;
    }

    public void addScore_2(int point)
    {
        score_2 += point;
    }
}
