using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndDisplay : MonoBehaviour
{
    public Text HighScoretxt;
    public Text Livestxt;
    public Text Nametxt;
    
    void Start()
    {
        HighScoretxt.text = "High Score: " + PlayerPrefs.GetInt("HighScore");
        Livestxt.text = "Lives: " + PlayerPrefs.GetInt("Lives");
        Nametxt.text = PlayerPrefs.GetString("Name");
    }
}
