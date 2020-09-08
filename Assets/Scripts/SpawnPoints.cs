using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoints : MonoBehaviour
{
    public GameObject[] spawnLocations;
    public GameObject[] spawnLocations2;
    public GameObject[] spawnLocations3;
    public GameObject[] spawnLocations4;
    public GameObject[] spawnLocations5;
    public GameObject page1;
    public GameObject page2;
    public GameObject page3;
    public GameObject page4;
    public GameObject page5;

    private Vector3 respawnLocation;

    private void Awake()
    {
        spawnLocations = GameObject.FindGameObjectsWithTag("spawnPoint");
        spawnLocations2 = GameObject.FindGameObjectsWithTag("spawnPoint2");
        spawnLocations3= GameObject.FindGameObjectsWithTag("spawnPoint3");
        spawnLocations4 = GameObject.FindGameObjectsWithTag("spawnPoint4");
        spawnLocations5= GameObject.FindGameObjectsWithTag("spawnPoint5");

    }
    // Start is called before the first frame update
    void Start()
    {
        page1 = (GameObject)Resources.Load("pageone", typeof(GameObject));
        respawnLocation = page1.transform.position;
        SpawnPage1();

        page2 = (GameObject)Resources.Load("pagetwo", typeof(GameObject));
        respawnLocation = page2.transform.position;
        SpawnPage2();

        page3 = (GameObject)Resources.Load("pagethree", typeof(GameObject));
        respawnLocation = page3.transform.position;
        SpawnPage3();

        page4 = (GameObject)Resources.Load("pagefour", typeof(GameObject));
        respawnLocation = page4.transform.position;
        SpawnPage4();

        page5 = (GameObject)Resources.Load("pagefive", typeof(GameObject));
        respawnLocation = page5.transform.position;
        SpawnPage5();
    }

    private void SpawnPage1()
    {
        int spawn = Random.Range(0, spawnLocations.Length);
        GameObject.Instantiate(page1, spawnLocations[spawn].transform.position, Quaternion.identity);
    }

    private void SpawnPage2()
    {
        int spawn = Random.Range(0, spawnLocations2.Length);
        GameObject.Instantiate(page2, spawnLocations2[spawn].transform.position, Quaternion.identity);
    }

    private void SpawnPage3()
    {
        int spawn = Random.Range(0, spawnLocations3.Length);
        GameObject.Instantiate(page3, spawnLocations3[spawn].transform.position, Quaternion.identity);
    }

    private void SpawnPage4()
    {
        int spawn = Random.Range(0, spawnLocations4.Length);
        GameObject.Instantiate(page4, spawnLocations4[spawn].transform.position, Quaternion.identity);
    }

    private void SpawnPage5()
    {
        int spawn = Random.Range(0, spawnLocations5.Length);
        GameObject.Instantiate(page5, spawnLocations5[spawn].transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
