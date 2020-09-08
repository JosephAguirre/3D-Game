using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Dropdown resolutionDropDown;

    Resolution[] resolutions;

    void Start()
    {
       resolutions = Screen.resolutions;
       resolutionDropDown.ClearOptions();
        List<string> resOptions = new List<string>();
        int currentResIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            resOptions.Add(option);
            if(resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResIndex = i;
            }
        }
       resolutionDropDown.AddOptions(resOptions);
       resolutionDropDown.value = currentResIndex;
       resolutionDropDown.RefreshShownValue();
    }

    public void setVolume(float vol)
    {
        audioMixer.SetFloat("Volume", vol);
    }

    public void setResolution(int resIndex)
    {
        Resolution resolution = resolutions[resIndex];
        Screen.SetResolution(resolution.width, resolution.width, true);
    }

    public void setFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}
