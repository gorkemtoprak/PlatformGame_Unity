using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedirLevel : MonoBehaviour
{
    public static int redLev;

    void Update()
    {
        if (redLev == 3)
        {
            SceneManager.LoadScene(redLev);
        }
    }
}
