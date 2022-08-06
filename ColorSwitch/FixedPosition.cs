using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedPosition : MonoBehaviour
{
    [SerializeField] Vector3 offset;
    [SerializeField] Vector3 fixedPosition;

    void Start()
    {
    }
    void Update()
    {
        fixedPosition = transform.position + offset; 
    }
}
