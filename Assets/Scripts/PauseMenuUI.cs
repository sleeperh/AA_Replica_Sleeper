using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuUI : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject pauseText;
    public GameObject newGameBtn;
    public GameObject saveGameBtn;
    public GameObject saveJSONBtn;
    public GameObject loadBtn;
    public GameObject musicTgle;
    public static bool pauseBool = false;


    private void Start()
    {
        PauseUI(false);
    }
    private void Update()
    {

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(!pauseBool)
            {
                PauseUI(true);
                pauseBool = true;
            }    
            else
            {
                PauseUI(false);
                pauseBool = false;
            }
        }
    }

    private void PauseUI(bool activeBool)
    {
        pausePanel.SetActive(activeBool);
        pauseText.SetActive(activeBool);
        newGameBtn.SetActive(activeBool);
        saveGameBtn.SetActive(activeBool);
        saveJSONBtn.SetActive(activeBool);
        loadBtn.SetActive(activeBool);
        musicTgle.SetActive(activeBool);
        if (activeBool)
        {
            Time.timeScale = 0;
        }
        else
            Time.timeScale = 1;
    }    
}
