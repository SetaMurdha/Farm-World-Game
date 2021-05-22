using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class playerController : MonoBehaviour,IPointerDownHandler,IPointerUpHandler, IDragHandler
{
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = new Vector2(eventData.position.x, transform.position.y);

        if(transform.localPosition.x < -80)
        {
            transform.localPosition = new Vector2(-80, 0);
        }
        if(transform.localPosition.x > 80)
        {
            transform.localPosition = new Vector2(80, 0);
        }

    }

    public void OnPointerDown(PointerEventData eventData)
    {

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        transform.localPosition = Vector2.zero;
    }
    
}
