using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect_Item : MonoBehaviour
{
    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player")
        {
            ScoreHolder.Score++;
            Destroy(gameObject);
        }
    }
}
