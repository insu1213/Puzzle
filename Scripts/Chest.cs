using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public GameObject chest;
    public GameObject key;
    public GameObject keyUI;
    bool playerKeyStatus;
    GameObject player;
    void Start()
    {
        player = GameObject.Find("Player");
    }

    void Update()
    {
        playerKeyStatus = player.GetComponent<Player>().keyStatus;
        keyUI.SetActive(playerKeyStatus);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(playerKeyStatus && collision.gameObject.CompareTag("Player"))
        {
            player.GetComponent<Player>().PointSet(5);
            player.GetComponent<Player>().keyStatus = false;
        }
    }
}
