using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBoundary : MonoBehaviour
{
    public float xMin;
    public float xMax;


    void Update()
    {
        Vector2 boundary = transform.position;

        if(boundary.x > xMin)
        {
            boundary.x = xMin;
        }
        if (boundary.x < xMax)
        {
            boundary.x = xMax;
        }

    }
}
