using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagerX : MonoBehaviour
{
    public AudioSource clickSound;
    public int sceneID;
    public void Player1()
    {
        clickSound.Play();
        SceneManager.LoadScene(1);
    }

    public void Player2()
    {
        clickSound.Play();
        SceneManager.LoadScene(2);
    }

    public void Exit()
    {
        clickSound.Play();
        Application.Quit();
    }

    public void Restart()
    {
        clickSound.Play();
        SceneManager.LoadScene(sceneID);
    }

    public void Menu()
    {
        clickSound.Play();
        SceneManager.LoadScene(0);
    }
}
