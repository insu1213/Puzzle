using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            GameObject.Find("Player").GetComponent<Rigidbody2D>().AddForce(new Vector2(-10f, 3f), ForceMode2D.Impulse);
            GameObject.Find("Player").GetComponent<Player>().Damaged(1);
        }
    }
}
