using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleBackground : MonoBehaviour
{

    void Start()
    {
        float height = Camera.main.orthographicSize * 2f;
        float width = height * Screen.width / Screen.height;

        if (transform.CompareTag("Background"))
        {
            transform.localScale = new Vector3(width,height,0);
        }
        else
        {
            transform.localScale = new Vector3(width + 3f,5,0);
        }

        
    }
    
}
