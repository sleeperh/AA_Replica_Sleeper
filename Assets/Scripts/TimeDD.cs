using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeDD : MonoBehaviour
{
    public Dropdown dropDown;
    public void TimeDropDown()
    {
        switch (dropDown.value)
        {
            case 1:
                PlayerPrefs.SetFloat("Time", 30);
                break;
            case 2:
                PlayerPrefs.SetFloat("Time", 60);
                break;
            default:
                PlayerPrefs.SetInt("Time", 30);
                break;
        }
    }    
}
