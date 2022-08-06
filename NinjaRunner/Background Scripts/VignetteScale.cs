using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VignetteScale : MonoBehaviour
{
    
    void Start()
    {
        SpriteRenderer sr = GetComponent<SpriteRenderer>();
        Vector3 tempScale = transform.localScale;

        float width = sr.sprite.bounds.size.x;
        float worldHeight = Camera.main.orthographicSize * 2.0f;
        float worldWidth = worldHeight / Screen.height * Screen.width;
        float height = worldHeight * Screen.width / Screen.height;

        tempScale.x = worldWidth / width;
        tempScale.y = height / worldHeight;
        transform.localScale = tempScale;
    }
}
