using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JumpButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public void OnPointerDown(PointerEventData data)
    {
        if (PlayerJump.instance != null)
            PlayerJump.instance.SetPower(true);
        Debug.Log("Touched");
    }
    public void OnPointerUp(PointerEventData data)
    {
        if (PlayerJump.instance != null)
            PlayerJump.instance.SetPower(false);
        Debug.Log("Released");
    }
}
