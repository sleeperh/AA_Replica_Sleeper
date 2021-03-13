using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed = 100f;
    private float sliderVal = 0f;
    private void Update()
    {
        sliderVal = UIMethods.rotatorSpeed;
        transform.Rotate(0f, 0f, speed * sliderVal * Time.deltaTime);
    }
}
