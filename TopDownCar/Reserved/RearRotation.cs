using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RearRotation : MonoBehaviour
{
    [SerializeField] Transform rearRotation;
    [SerializeField] Transform followCar;
    [SerializeField] float rotationSpeed;

    void Update()
    {
        GetInput();
        FollowCar();
    }
    void GetInput()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            RearRotator();
        }
    }
    void RearRotator()
    {
        rearRotation.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
    void FollowCar()
    {
        followCar.transform.position = transform.position;
    }
}
