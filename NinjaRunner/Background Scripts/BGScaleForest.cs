using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScaleForest : MonoBehaviour
{
    void Start()
    {
        float height = Camera.main.orthographicSize * 2f;
        float width = height * Screen.width / Screen.height;

        if (transform.name == "ForestBackground")
        {
            transform.localScale = new Vector3(width, height, 1);
            transform.position = new Vector3(0, 0, 5);
        }
        else
        {
            transform.localScale = new Vector3(width, height, 1);
            transform.position = new Vector3(0, 0, 5);
        }
    }
}
