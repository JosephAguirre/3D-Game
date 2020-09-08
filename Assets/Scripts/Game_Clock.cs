using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Clock : MonoBehaviour
{
    public bool isGameStarting = false;
    bool calledOnce = false;
    public float gameTime = 300f;
    [SerializeField]
    Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameStarting)
        {
            if (gameTime > 0)
            {

                TimeSpan spanTime = TimeSpan.FromSeconds(gameTime);
                timerText.text = "Time: " + spanTime.Minutes + " : " + spanTime.Seconds;
                gameTime -= 1 * Time.deltaTime;
            }
            else
            {
                if (!calledOnce)
                {
                    calledOnce = true;
                    timerText.text = "Time: GAME OVER!";
                    this.GetComponent<Game_Over>().gameOver();
                }
            }
        }
    }
}
