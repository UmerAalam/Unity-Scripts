using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //Download and .Net FrameWork
    public Transform player;
    [SerializeField] Vector3 offset;
    void LateUpdate()
    {
        transform.position = player.transform.position;
    }
}
