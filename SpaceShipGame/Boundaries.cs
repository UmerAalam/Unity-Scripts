﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    private Vector2 screenBounds;
    float objectWidth;
    float objectHeight;
    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        objectWidth = GetComponent<SpriteRenderer>().bounds.size.x / 2;
        objectHeight = GetComponent<SpriteRenderer>().bounds.size.y / 2;
    }

    void LateUpdate()
    {
        Vector2 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, screenBounds.x + objectWidth, screenBounds.x * 1 - objectWidth);
        viewPos.y = Mathf.Clamp(viewPos.y, screenBounds.y + objectHeight, screenBounds.y * -1 - objectHeight);
    }
}
