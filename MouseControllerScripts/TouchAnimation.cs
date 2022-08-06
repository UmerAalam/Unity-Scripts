using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchAnimation : MonoBehaviour
{
    [SerializeField] GameObject placeAnimation;
    Vector3 mousePos;
    Vector3 objectOffset;

    void Update()
    {
        objectOffset = new Vector3(0,0,10);
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseDown()
    {
        Instantiate(placeAnimation, mousePos + objectOffset , Quaternion.identity);
    }
    private void OnMouseUp()
    {
        StartCoroutine(DestroyGameObject());
    }
    IEnumerator DestroyGameObject()
    {
        yield return new WaitForSeconds(3f);
        Destroy(placeAnimation);
    }
}
