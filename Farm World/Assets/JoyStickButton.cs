
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class JoyStickButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    [SerializeField] private GameObject character;
    private Rigidbody2D rb;
    private Image bgImage;
    private Image joyStickImage;

    private void Start()
    {
        bgImage = GetComponent<Image>();
        joyStickImage = transform.GetChild(0).GetComponent<Image>();
        Debug.Log(bgImage);
        Debug.Log(joyStickImage);
    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {

    }

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {

    }

    void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
    {

    }

    void movementChar()
    {

    }
}
