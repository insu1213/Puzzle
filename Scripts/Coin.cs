using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            audioSource.Play();
            transform.gameObject.SetActive(false);
            Player player = GameObject.Find("Player").GetComponent<Player>();
            player.PointSet(1);
        }
    }
}
