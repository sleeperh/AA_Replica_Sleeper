using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMethods : MonoBehaviour
{
    public static float rotatorSpeed = 1f;
    public static float pinSpeed = 1f;
    public void StartGame()
    {
        SceneManager.LoadScene("MainLevel");
    }

    public void NewGame()
    {
        SceneManager.LoadScene("Intro");
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void SetRotatorSpeed(float valMultiplier)
    {
        rotatorSpeed = valMultiplier;
    }

    public void SetPinSpeed(float valMulitiplier)
    {
        pinSpeed = valMulitiplier;
    }
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

}
