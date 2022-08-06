using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleMouse : MonoBehaviour
{
    [SerializeField] GameObject mainObject;
    Vector2 prevMousePosition;
    public float sizingFactor = 0.03f;
    Vector3 minimumScale;
    Vector3 objectOffset;

    private void Start()
    {
        objectOffset = new Vector3(0,0,10);
        // Setting the minimum scale of the mainObject
        minimumScale = new Vector3(1.0f, 1.0f, 1.0f);
    }

    void OnMouseDrag()
    {
        Vector2 mousePosition = Input.mousePosition;

        if (Input.GetMouseButton(0))
        {
            // Set this object's position to where the mouse is being held down by the left click.
            //transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = Vector3.zero;
            // Change the scale of mainObject by comparing previous frame mousePosition with this frame's position, modified by sizingFactor.
            Vector3 scale = mainObject.transform.localScale;
            scale.x = scale.x + (mousePosition.x - prevMousePosition.x) * sizingFactor;
            scale.y = scale.x;
            scale.z = scale.x;
            mainObject.transform.localScale = scale;

            // Checking if current scale is less than minimumScale, if yes, mainObject scales takes value from minimumScale
            if (scale.x < minimumScale.x)
            {
                mainObject.transform.localScale = minimumScale;
            }
        }

        prevMousePosition = mousePosition;
    }
}

