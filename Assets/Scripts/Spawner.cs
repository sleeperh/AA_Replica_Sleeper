using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pinPrefab;

    private void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            if (!PauseMenuUI.pauseBool)
            {
                SpawnPin();
            }
        }
    }
    void SpawnPin()
    {
        Instantiate(pinPrefab, transform.position, transform.rotation); // spawn pin prefab at (attached) game object position and rotation
    }
}
