using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerMove : MonoBehaviour
{
    public float DelayTime;
    bool DelayCheck = false;
    Vector2 trFix;
    Vector2 targetPosition;
    bool upDown; // up: false, down: true
    void Start()
    {
        trFix = transform.position;
        targetPosition = new Vector2(trFix.x, trFix.y - 11);
        upDown = true;
        StartCoroutine(HammerDelay(DelayTime));
    }
    void Update()
    {
        if(DelayCheck)
        {
            if (Vector2.Distance(transform.position, targetPosition) < 0.1f && upDown == true)
            {
                trFix = transform.position;
                targetPosition = new Vector2(trFix.x, trFix.y + 11);
                upDown = false;
            }
            else if (Vector2.Distance(transform.position, targetPosition) < 0.1f)
            {
                trFix = transform.position;
                targetPosition = new Vector2(trFix.x, trFix.y - 11);
                upDown = true;
            }
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, Time.deltaTime * 7);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {

            GameObject.Find("Player").GetComponent<Rigidbody2D>().AddForce(new Vector2(-10f, 3f), ForceMode2D.Impulse);
            GameObject.Find("Player").GetComponent<Player>().Damaged(1);
            
        }
    }

    IEnumerator HammerDelay(float DelayTime)
    {
        yield return new WaitForSeconds(DelayTime);
        DelayCheck = true;
    }
}
