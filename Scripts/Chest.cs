using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public GameObject chest;
    public GameObject key;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject player = GameObject.Find("Player");
        bool playerKeyStatus = player.GetComponent<Player>().keyStatus;
        if(playerKeyStatus && collision.gameObject.CompareTag("Player"))
        {
            player.GetComponent<Player>().PointSet(5);
        }
    }

}
