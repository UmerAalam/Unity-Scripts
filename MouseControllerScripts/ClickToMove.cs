using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToMove : MonoBehaviour
{
    [SerializeField] float followTime;
    Vector3 mousePosition;
    Vector3 offset;

    private void OnMouseDrag()
    {
        offset = new Vector3(0,0,10);
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Vector3.Lerp(transform.position,mousePosition + offset,followTime * Time.deltaTime);
    }
    private void OnMouseUp()
    {
        transform.position = transform.position;
    }
}
