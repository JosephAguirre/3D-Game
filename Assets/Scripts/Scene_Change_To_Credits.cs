using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Change_To_Credits : MonoBehaviour
{

    public void ToCreditsScene()
    {
        SceneManager.LoadScene("Credits_Scene");
    }

}
