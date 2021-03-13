using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MusicSystem : MonoBehaviour
{
    [SerializeField]
    private AudioSource music;
    [SerializeField]
    private Toggle toggle;

    public void Awake()
    {
        if (!PlayerPrefs.HasKey("Music"))
        {
            PlayerPrefs.SetInt("Music", 1);
            toggle.isOn = true;
            music.enabled = true;
            PlayerPrefs.Save();
        }
        else
        {
            if (PlayerPrefs.GetInt("Music") == 0)
            {
                music.enabled = false;
                toggle.isOn = false;
            }
            else
            {
                music.enabled = true;
                toggle.isOn = true;
            }
        }
        
    }
    public void Update()
    {
        PlayerPrefs.GetInt("Music");

    }
}
