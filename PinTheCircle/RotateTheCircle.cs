using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTheCircle : MonoBehaviour
{
    [SerializeField] float rotationSpeed;
    bool canRotate;
    float angle;

    void Awake()
    {
        canRotate = true;   
    }

    void Update()
    {
        if(canRotate)
        {
            RotateCircle();
        }
    }
    void RotateCircle()
    {
        angle = transform.rotation.eulerAngles.z;
        angle += rotationSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(new Vector3(0,0,angle));
    }
}
