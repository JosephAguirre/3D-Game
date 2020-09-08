using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Change_To_Game : MonoBehaviour
{

    public void ToGameScene()
    {
        SceneManager.LoadScene("TestScene");
    }

}
