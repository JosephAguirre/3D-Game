using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight_Switch : MonoBehaviour
{
    static public bool isOn;
    AudioSource flashlightClick;

    private void Awake()
    {
        flashlightClick = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha3)){
            this.GetComponent<Light>().enabled = true;
            isOn = true;
            flashlightClick.Play();
        }
        if (Input.GetKey(KeyCode.Alpha4))
        {
            this.GetComponent<Light>().enabled = false;
            isOn = false;
            flashlightClick.Play();
        }
    }
}
