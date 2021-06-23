using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenuFunct : MonoBehaviour
{
    public AudioSource buttonPress;

    public void PlayGame()
    {
        buttonPress.Play();
        RedirLevel.redLev = 3;
        SceneManager.LoadScene(2);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
