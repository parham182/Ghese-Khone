
using UnityEngine;
using UnityEngine.EventSystems;

public class InputHandeler : MonoBehaviour,
    IPointerDownHandler,
    IPointerUpHandler,
    IPointerExitHandler
{
    public int direction;
    public static float input;

    public void OnPointerDown(PointerEventData eventData)
    {
        input = direction;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (input == direction)
            input = 0;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (input == direction)
            input = 0;
    }
}
