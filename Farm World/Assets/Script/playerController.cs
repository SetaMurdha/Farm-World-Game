using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class playerController : MonoBehaviour,IPointerDownHandler,IPointerUpHandler, IDragHandler
{
    public GameObject player;
    public float moveSpeed;

    Rigidbody2D playerRigid;
    SpriteRenderer playerSprite;
    Animator selfAnimation;

    private void Start()
    {
        playerRigid = player.GetComponent<Rigidbody2D>();
        playerSprite = player.GetComponent<SpriteRenderer>();
        selfAnimation = player.GetComponent<Animator>();
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = new Vector2(eventData.position.x, transform.position.y);

        if(transform.localPosition.x < -40)
        {
            transform.localPosition = new Vector2(-40, 0);
        }
        if(transform.localPosition.x > 40)
        {
            transform.localPosition = new Vector2(40, 0);
        }

    }

    public void OnPointerDown(PointerEventData eventData)
    {
        StartCoroutine("Move");
        selfAnimation.SetBool("Walk", true);

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        transform.localPosition = Vector2.zero;
        playerRigid.velocity = Vector2.zero;
        StopCoroutine("Move");
        selfAnimation.SetBool("Walk", false);
    }
    
    IEnumerator Move()
    {
        while (true)
        {
            if (transform.localPosition.x < 0)
            {
                playerRigid.velocity = new Vector2(moveSpeed * -1, playerRigid.velocity.y);
                playerSprite.flipX = true;
            }
            if(transform.localPosition.x > 0)
            {
                playerRigid.velocity = new Vector2(moveSpeed, playerRigid.velocity.y);
                playerSprite.flipX = false;
            }

            yield return null;
        }
    }

}
