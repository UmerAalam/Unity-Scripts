using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerFollow;

    void Update()
    {
        if (playerFollow.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x,playerFollow.position.y,transform.position.z);
        }
    }
}
