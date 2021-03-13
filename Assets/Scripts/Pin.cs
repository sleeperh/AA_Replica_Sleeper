using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pin : MonoBehaviour
{
    private bool isPinned = false;
 
    float sliderVal = 0f;
    float speed = 20f;
    int lifeCount;
    public Rigidbody2D rb;
    public static int[] HighScoreGame = new int[5];
    
    public static int j = 0;
    int counter = 0;
    private void Start()
    {
        counter = j;
        lifeCount = PlayerPrefs.GetInt("Lives") - 1;
        counter++;
    }
    private void FixedUpdate()
    {
        
        if(!isPinned)
        {
            sliderVal = UIMethods.pinSpeed;
            rb.MovePosition(rb.position + Vector2.up * sliderVal * speed * Time.deltaTime);
        }
        
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Rotator")
        {
            transform.SetParent(col.transform);
            Score.PinCount++;
            isPinned = true;
        }
        else if (col.tag == "Pin")
        {
            if (PlayerPrefs.GetInt("Lives") > 0)
            {
                HighScoreGame[j] = PlayerPrefs.GetInt("Score");
                Debug.Log("j = " + j.ToString());
                Debug.Log("Score = " + HighScoreGame[j].ToString());
                j = counter;

                PlayerPrefs.SetInt("Lives", lifeCount);
                FindObjectOfType<GameManager>().EndGame();
            }
            else
            {
                j = 0;
                HighScorer();
                SceneManager.LoadScene("Exit");
            }    
        }
    }
    public void HighScorer()
    {
        int highScore = HighScoreGame[0];
        for(int i = 0; i < 5; i++)
        {
            Debug.Log(HighScoreGame[i].ToString() + " " + i.ToString());
            if (HighScoreGame[i] > highScore)
            {
                
                highScore = HighScoreGame[i];
            }
        }
        PlayerPrefs.SetInt("HighScore", highScore);
    }
}
