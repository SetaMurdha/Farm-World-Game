using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool BLeft;
    private bool BRight;
    private bool BRun;
    SpriteRenderer playerSplit;
    private float horizontalMove;
    [SerializeField] private float speed = 8f;
    [SerializeField] private float Runforces = 2f;

    public void PDownJump()
    {
        BRun = true;
    }
    public void PUpJump()
    {
        BRun = false;
    }

    public void PDownLeft()
    {
        BLeft = true;
    }
    public void PUpLeft()
    {
        BLeft = false;
    }
    public void PDownRight()
    {
        BRight = true;
    }
    public void PUpRight()
    {
        BRight = false;
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerSplit = GetComponent<SpriteRenderer>();
        BLeft = false;
        BRight = false;
        BRun = false;

    }

    private void Update()
    {
        movement();
    }

    private void movement()
    {
        if (BLeft)
        {
            horizontalMove = -speed;
            playerSplit.flipX = true;
            if (BRun)
            {
                horizontalMove = horizontalMove * Runforces;
            }

        }
        else if (BRight)
        {
            horizontalMove = speed;
            playerSplit.flipX = false;
            if (BRun)
            {
                horizontalMove = horizontalMove * Runforces;
            }
        }
        else
        {
            horizontalMove = 0;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalMove, rb.velocity.y);
    }

}
