using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameDisplay : MonoBehaviour
{
    public Text nameText;
 
    void Start()
    {
        nameText.text = PlayerPrefs.GetString("Name");
    }

}
