using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Manager : MonoBehaviour
{
    #region Singleton

    public static Player_Manager instance;

    private void Awake()
    {
        instance = this;
    }

    #endregion

    public Transform Enemy;

     void Update()
    {
        if (Enemy_AI.isDead)
        {
            transform.LookAt(Enemy);

        }
    }

}
