using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameInput : MonoBehaviour
{
    public InputField nameInput;
    
    void Update()
    {
        PlayerPrefs.SetString("Name", nameInput.text);
    }
}
