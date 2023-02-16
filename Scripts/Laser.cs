using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("¥Í¿Ω");
        if (collision.gameObject.CompareTag("Player"))
        {

            GameObject.Find("Player").GetComponent<Rigidbody2D>().AddForce(new Vector2(-10f, 3f), ForceMode2D.Impulse);
            GameObject.Find("Player").GetComponent<Player>().Damaged(1);
        }
    }
}
