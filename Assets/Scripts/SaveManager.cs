using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.SceneManagement;

public class SaveManager : MonoBehaviour
{
    public GameObject pinPrefab;
    public GameObject rotator;
    private GameObject[] pins;
    private GameObject pin;
    private Save CreateSaveGameObject()
    {
        Save save = new Save();
        save.Score = Score.PinCount;
        save.TimeRemaining = Timer.timeRemaining;
        save.PinSlider = UIMethods.pinSpeed;
        save.RotatorSlider = UIMethods.rotatorSpeed;
        save.Lives = PlayerPrefs.GetInt("Lives");
        save.PlayerName = PlayerPrefs.GetString("Name");

        return save;
    }
    public void SaveGame()
    {
        Save save = CreateSaveGameObject(); // call the above function to initialize an instance of the save class with the appropriate save info 
        BinaryFormatter bf = new BinaryFormatter(); // create an instance of the binary formatter
        FileStream file = File.Create(Application.persistentDataPath + "/gamesave.save"); // call the file something
        bf.Serialize(file, save); // serialize the file
        file.Close(); // close the file
        Debug.Log("Game Saved");
    }

    public void SaveAsJSON()
    {
        Save save = CreateSaveGameObject();
        string json = JsonUtility.ToJson(save);

        Debug.Log("Saving as JSON: " + json);
        save = JSONtoSave(json);
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/gamesave.save");
        bf.Serialize(file, save);
        file.Close();
    }
    public Save JSONtoSave(string json)
    {
        Save save = JsonUtility.FromJson<Save>(json);
        return save;
    }
    public void LoadGame()
    {
        if (File.Exists(Application.persistentDataPath + "/gamesave.save")) // if there exists a save file
        {
            BinaryFormatter bf = new BinaryFormatter(); // create instance of binary formatter
            FileStream file = File.Open(Application.persistentDataPath + "/gamesave.save", FileMode.Open); // open the save file... you can call it what want "/gamesave.poo" ??
            Save save = (Save)bf.Deserialize(file); // deserialize it 
            file.Close();
            // load the saved information into the game
            Score.PinCount = save.Score;
            Timer.timeRemaining = save.TimeRemaining;
            UIMethods.pinSpeed = save.PinSlider;
            UIMethods.rotatorSpeed = save.RotatorSlider;
            PlayerPrefs.SetInt("Lives", save.Lives);
            PlayerPrefs.GetString("Name", save.PlayerName);

            Debug.Log("Game Loaded " + "Score: " + save.Score);
        }
        else
            Debug.Log("No game saved!");
    }
    public void NewGame()
    {
        SceneManager.LoadScene("Intro");
    }

    
    
}
