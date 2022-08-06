using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithMouse : MonoBehaviour
{
    [SerializeField] float moveTime;
    Vector3 mousePosition;
    Vector3 offset;
    Vector3 maxPosition;
    void Update()
    {
        offset = new Vector3(0,0,10);
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition + offset);
        transform.position = Vector3.Lerp(transform.position, mousePosition, moveTime * Time.deltaTime);
    }
}
