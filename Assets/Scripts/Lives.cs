using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Lives : MonoBehaviour
{
    public Dropdown dropDown;

    public static int lives;
    public void LivesMenu()
    {
        switch (dropDown.value)
        {
            case 1:
                lives = 3;
                break;
            case 2:
                lives = 4;
                break;
            case 3:
                lives = 5;
                break;
            default:
                lives = 3;
                break;
        }
        PlayerPrefs.SetInt("Lives", lives);
    }
}
