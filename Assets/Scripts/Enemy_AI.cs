 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy_AI : MonoBehaviour
{
    public GameObject[] withinRadius;
    public Transform Player;
    int MoveSpeed = 4;
    public float maxDistance = 75.0f;
    public GameObject canvasUI;
    static public bool isDead;
    AudioSource[] sounds;
    AudioSource enemyScream;
    AudioSource enemySteps;

    private void Awake()
    {
        sounds = GetComponents<AudioSource>();
        enemyScream = sounds[0];
        enemySteps = sounds[1];
    }

    void Update() 
    {
        withinRadius = GameObject.FindGameObjectsWithTag("Player");
        Vector3 offset = Player.position - this.transform.position;
        float sqrLen = offset.sqrMagnitude;
        GetComponent<Animator>().SetBool("IsWalking", false);


        if (sqrLen < maxDistance * maxDistance)
        {

            transform.LookAt(Player);
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;
            GetComponent<Animator>().SetBool("IsWalking", true);
            enemySteps.mute = false;
            if (Flashlight_Switch.isOn)
            {
                MoveSpeed = 9;
            }

            if(Flashlight_Switch.isOn == false)
            {
                MoveSpeed = 5;
            }
        }
        else
        {
            enemySteps.mute = true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Player")
        {
            enemyScream.Play();
            canvasUI.GetComponent<Game_Over>().gameOver();
            isDead = true;
        }

    }
}