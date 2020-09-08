using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Change_To_Settings : MonoBehaviour
{

    public void ToSettingsScene()
    {
        SceneManager.LoadScene("Settings_Scene");
    }

}
