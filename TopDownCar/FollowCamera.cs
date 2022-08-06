using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform car;
    [SerializeField] Vector3 cameraOffset;

    void LateUpdate()
    {
        transform.position = car.transform.position + cameraOffset;
    }
}
