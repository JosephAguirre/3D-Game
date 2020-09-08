using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Start : MonoBehaviour
{
    bool calledOnce = false;
    bool calledOnce2 = false;
    float currentTime = 0f;
    float startingTime = 3.5f;
    [SerializeField]
    RectTransform gamePanel;
    [SerializeField]
    Text countdownText;
    [SerializeField]
    GameObject player;
    [SerializeField]
    GameObject playerCamera;
    [SerializeField]
    GameObject enemy;
    AudioSource[] sounds;
    AudioSource forestMusic;

    void RemoveText()
    {
        if (!calledOnce)
        {
            calledOnce = true;
            countdownText.gameObject.SetActive(false);
            gamePanel.gameObject.SetActive(false);
        }
    }

    void ActivatePlayer()
    {
        if (!calledOnce2)
        {
            calledOnce2 = true;
            player.GetComponent<Player_Movement>().enabled = true;
            playerCamera.GetComponent<Player_Look>().enabled = true;
            enemy.GetComponent<Enemy_AI>().enabled = true;
        }
    }

    void StartTimer()
    {
         this.GetComponent<Game_Clock>().isGameStarting = true;
    }

    private void Awake()
    {
        sounds = GetComponents<AudioSource>();
        forestMusic = sounds[0];
    }

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
        player.GetComponent<Player_Movement>().enabled = false;
        playerCamera.GetComponent<Player_Look>().enabled = false;
        enemy.GetComponent<Enemy_AI>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");
        if(currentTime <= 1)
        {
            currentTime = 1;
            countdownText.text = "Start!";
            Invoke("RemoveText", 1f);
            Invoke("ActivatePlayer", 1f);
            Invoke("StartTimer", 1f);
        }
    }
}
