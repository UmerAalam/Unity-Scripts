﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] Transform car;
    [SerializeField] Vector3 offset;

    void LateUpdate()
    {
       transform.position = car.transform.position + offset; 
    }
}
