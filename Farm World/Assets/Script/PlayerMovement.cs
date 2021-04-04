using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private bool BLeft;
    private bool BRight;
    private bool BJump;
    private float horizontalMove;
    private float verticalMove;
    [SerializeField] private float speed = 10f;
    [SerializeField] private float jumpforces = 5f;
    [SerializeField] private float gravity = 8f;

    public void PDownJump()
    {
        BJump = true;
    }
    public void PUpJump()
    {
        BJump = false;
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
        BLeft = false;
        BRight = false;
        BJump = false;

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
            if (BJump)
            {
                verticalMove = jumpforces;
            }
            else
            {
                verticalMove = -gravity;
            }
        }
        else if (BRight)
        {
            horizontalMove = speed;
            if (BJump)
            {
                verticalMove = jumpforces;
            }
            else
            {
                verticalMove = -gravity;
            }
        }
        else if (BJump)
        {
            verticalMove = jumpforces;
        }
        else
        {
            horizontalMove = 0;
            verticalMove = -gravity;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalMove, rb.velocity.y);
        rb.velocity = new Vector2(rb.velocity.x, verticalMove);
    }

}
