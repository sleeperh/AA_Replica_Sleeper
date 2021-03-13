using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    public Text timerTxt;
    public static float timeRemaining = 30f;

    private void Start()
    {
        timeRemaining = PlayerPrefs.GetFloat("Time");
    }
    
    void FixedUpdate()
    {
        timerTxt.text = timeRemaining.ToString("00.000");
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            PlayerPrefs.SetFloat("Time", timeRemaining); // allows for continual countdown uninhibited by player death
        }
        else
        {
            Pin.HighScoreGame[Pin.j] = Score.PinCount;
            FindObjectOfType<Pin>().HighScorer();
            SceneManager.LoadScene("Exit");
        }
    }
}
