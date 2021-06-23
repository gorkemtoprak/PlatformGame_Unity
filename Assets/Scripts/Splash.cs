using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Splash : MonoBehaviour
{
    public GameObject logo;

    void Start()
    {
        StartCoroutine(RunSplash());
    }
    IEnumerator RunSplash()
    {
        yield return new WaitForSeconds(0.5f);
        logo.SetActive(true);
        yield return new WaitForSeconds(4.5f);
        SceneManager.LoadScene(1);
    }
}
