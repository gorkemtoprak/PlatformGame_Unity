using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Finish : MonoBehaviour
{

    public GameObject levelMusic;
    public AudioSource levelComplete;
    public GameObject levelTimer;
    public GameObject timeLeft;
    public GameObject theScore;
    public GameObject totalScore;
    public int timeCal;
    public int scoreCal;
    public int totScore;

     void OnTriggerEnter()
    {
        timeCal = Timer.extendScore * 1;
        timeLeft.GetComponent<Text>().text = "Time left: " + Timer.extendScore  ;
        theScore.GetComponent<Text>().text = "Score: " + Score.currentScore;
        totScore = Score.currentScore + timeCal;
        totalScore.GetComponent<Text>().text = "Total Score: " + totScore;
        levelMusic.SetActive(false);
        levelTimer.SetActive(false);
        levelComplete.Play();
        StartCoroutine(CalculateScore());
    }

    IEnumerator CalculateScore()
    {
        timeLeft.SetActive(true);
        yield return new WaitForSeconds(1);
        theScore.SetActive(true);
        yield return new WaitForSeconds(1);
        totalScore.SetActive(true);
        yield return new WaitForSeconds(1);
    }
}
