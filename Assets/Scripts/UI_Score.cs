using UnityEngine;
using UnityEngine.UI;

public class UI_Score : MonoBehaviour
{
    public int papersCollected = 0;
    public int papersToWin = 5;
    bool calledOnce = false;
    public Text scoreText;
    AudioSource[] sounds;
    AudioSource collectSFX;
    int counter = 1;

    public void ScoreUpdate()
    {
        scoreText.text = "Papers: " + papersCollected.ToString()
                            + "/" + papersToWin.ToString();
    }

    public void playCollectSFX()
    {
        collectSFX.Play();
    }

    private void Awake()
    {
        sounds = GetComponents<AudioSource>();
        collectSFX = sounds[1];
    }

    // Update is called once per frame
    void Update()
    {
        papersCollected = (int)ScoreHolder.Score;
        ScoreUpdate();
        if(papersCollected == counter)
        {
            counter++;
            playCollectSFX();
        }
        if((papersCollected == papersToWin) && !calledOnce)
        {
            calledOnce = true;
            this.GetComponent<Game_Over>().gameOver();
        }
    }
}
