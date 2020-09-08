using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Over : MonoBehaviour
{
    public bool isGameOver = false;
    bool calledOnce = false;
    [SerializeField]
    RectTransform gamePanel;
    [SerializeField]
    Text gameOverText;
    [SerializeField]
    GameObject player;
    [SerializeField]
    GameObject playerCamera;
    [SerializeField]
    GameObject enemy;
    AudioSource[] sounds;
    AudioSource forestMusic;

    public void showText()
    {
            gamePanel.gameObject.SetActive(true);
            gameOverText.gameObject.SetActive(true);
    }

    public void disablePlayer()
    {
            player.GetComponent<Player_Movement>().enabled = false;
            playerCamera.GetComponent<Player_Look>().enabled = false;
            enemy.GetComponent<Enemy_AI>().enabled = false;
    }

    void stopMusic()
    {
        forestMusic.mute = true;
    }

    public void toMenu()
    {
        gameObject.GetComponent<Scene_Change_To_Menu>().ToMenuScene();
    }

    public void gameOver()
    {
        if(!calledOnce)
        {
            calledOnce = true;
            gameOverText.text = ScoreHolder.Score == this.GetComponent<UI_Score>().papersToWin ? "YOU WIN" : "YOU LOSE";
            showText();
            disablePlayer();
            stopMusic();
            Invoke("toMenu", 5f);
        }
    }

    private void Awake()
    {
        sounds = GetComponents<AudioSource>();
        forestMusic = sounds[0];
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
