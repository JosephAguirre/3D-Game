using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Change_To_Instructions : MonoBehaviour
{

    public void ToInstructionsScene()
    {
        SceneManager.LoadScene("Instructions_Scene");
    }

}

