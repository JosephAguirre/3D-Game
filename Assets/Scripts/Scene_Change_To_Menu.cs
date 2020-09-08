using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_Change_To_Menu : MonoBehaviour
{
    private void Update()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = (true);
    }

    public void ToMenuScene()
    {
        SceneManager.LoadScene("Menu_Scene");
    }

}
