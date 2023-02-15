using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerMove : MonoBehaviour
{
    Vector2 trFix;
    Vector2 targetPosition;
    bool upDown; // up: false, down: true
    void Start()
    {
        trFix = transform.position;
        targetPosition = new Vector2(trFix.x, trFix.y - 9);
        upDown = true;
    }
    void Update()
    {
        if (Vector2.Distance(transform.position, targetPosition) < 0.1f && upDown == true) {
            trFix = transform.position;
            targetPosition = new Vector2(trFix.x, trFix.y + 11);
            upDown = false;
        } else if(Vector2.Distance(transform.position, targetPosition) < 0.1f)
        {
            trFix = transform.position;
            targetPosition = new Vector2(trFix.x, trFix.y - 11);
            upDown = true;
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, Time.deltaTime * 10);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("ÁøÀÔÇÔ3");
            GameObject.Find("Player").GetComponent<Rigidbody2D>().AddForce(new Vector2(-50f, 3f), ForceMode2D.Impulse);
            GameObject.Find("Player").GetComponent<PlayerMove>().playerAnim.SetTrigger("hurt");
        }
    }
}
