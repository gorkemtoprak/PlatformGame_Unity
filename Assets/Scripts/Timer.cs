using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject time1;
    public GameObject time2;
    public bool takeTime;
    public int seconds = 150;
    public static int extendScore;

    void Update()
    {
       extendScore = seconds;
       if(takeTime == false)
        {
            StartCoroutine(SubtractSecond());
        } 
    }

    IEnumerator SubtractSecond()
    {
        takeTime = true;
        seconds -= 1;
        time1.GetComponent<Text>().text = "" + seconds;
        time2.GetComponent<Text>().text = "" + seconds;
        yield return new WaitForSeconds(1);
        takeTime = false;

    }

}
