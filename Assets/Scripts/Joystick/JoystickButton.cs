using UnityEngine;
using UnityEngine.EventSystems;

public class JoystickButton : MonoBehaviour , IPointerDownHandler, IPointerUpHandler
{
    [HideInInspector]
    public bool Pressed;

    public void OnPointerDown(PointerEventData eventData)
    {
        Pressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Pressed = false;
    }
}
