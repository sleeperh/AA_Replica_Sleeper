using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int PinCount = 0;
    public Text text;
    void Start()
    {
        PinCount = 0;
    }

    void Update()
    {
        
        PlayerPrefs.SetInt("Score", PinCount);
        text.text = PinCount.ToString();
    }
}
