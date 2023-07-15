using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] spawnBall;
    private int spawnIndex;
    private int spawnDelay = 0;
    private float spawnRate = 0.5f;
    private Vector3 spawnPos;
    private GameManager gameManager;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    }
    /*
    private void OnEnable()
    {
        InvokeRepeating("SpawnBall", spawnDelay, spawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke("SpawnBall");
    }

    public void SpawnBall()
    {
        spawnIndex = Random.Range(0, spawnBall.Length);
        spawnPos = new Vector3(0.5f, 0.1f, -1);
        Instantiate(spawnBall[spawnIndex], spawnPos, spawnBall[spawnIndex].transform.rotation);
    }
    */
}
