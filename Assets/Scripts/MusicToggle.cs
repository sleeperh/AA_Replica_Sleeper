using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicToggle : MonoBehaviour
{
    [SerializeField]
    private Toggle musicToggle;
    [SerializeField]
    private AudioSource music;
    private void Start()
    {

        PlayerPrefs.GetInt("Music");
    }
    public void ToggleMusic()
    {
        if (musicToggle.isOn)
        {
            PlayerPrefs.SetInt("Music", 1);
            music.enabled = true;
            music.Play();
        }
        else
        {
            PlayerPrefs.SetInt("Music", 0);
            music.enabled = false;
            music.Stop();
        }

        PlayerPrefs.Save();
    }
}
