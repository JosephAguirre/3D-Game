using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsScene : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(SleepTimer());
    }

    IEnumerator SleepTimer()
    {
        yield return new WaitForSeconds(15);
        SceneManager.LoadScene("Menu_Scene");
    }

    // Update is called once per frame
    void Update()
    {

    }

}
