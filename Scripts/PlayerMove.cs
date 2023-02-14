using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject playerFoot;
    GameObject player;
    Rigidbody2D playerRid;
    Animator playerAnim;
    

    int playerSpeed;
    float playerCurrentVelocity;
    float playerMaxSpeed;

    void Start()
    {
        player = GameObject.Find("Player");
        playerRid = player.GetComponent<Rigidbody2D>();
        playerAnim = player.GetComponent<Animator>();

        playerSpeed = 10;
        playerMaxSpeed = 10;
    }

    void Update()
    {
        Debug.DrawRay(player.transform.position, Vector2.down * 3.0f, Color.green);

        if (Input.GetButtonUp("Horizontal"))
        {
            playerAnim.SetBool("isRun", false);
            playerRid.velocity = new Vector2(playerRid.velocity.normalized.x * 0.5f, playerRid.velocity.y);
        }


        if (playerAnim.GetBool("isJump") == false)
        {
            Debug.Log("ÁøÀÔÇÔ");
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                playerRid.AddForce(new Vector2(0, 10), ForceMode2D.Impulse);
                playerAnim.SetBool("isRun", false);
                playerAnim.SetBool("isJump", true);

            }
        }
        
    }

    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        playerCurrentVelocity = playerRid.velocity.x;
        
        if (Input.GetKey(KeyCode.LeftArrow) && playerCurrentVelocity > -playerMaxSpeed)
        {
            player.transform.localScale = new Vector3(-2, 2, 1);
            playerAnim.SetBool("isRun", true);
            playerRid.AddForce(new Vector2(playerSpeed * h * Time.deltaTime, 0), ForceMode2D.Impulse);
        }

        if (Input.GetKey(KeyCode.RightArrow) && playerCurrentVelocity < playerMaxSpeed)
        {
            player.transform.localScale = new Vector3(2, 2, 1);
            playerAnim.SetBool("isRun", true);
            playerRid.AddForce(new Vector2(playerSpeed * h * Time.deltaTime, 0), ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            playerAnim.SetBool("isJump", false);
        }
    }
}
