using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallIndicator : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Vector3 offset;
    void Update()
    {
      FollowPlayer();
      TellRotation();
    }
    void FollowPlayer()
    {
        transform.position = player.transform.position + offset;
    }
    void TellRotation()
    {
    float horizontal = Input.GetAxisRaw("Horizontal");
    float vertical = Input.GetAxisRaw("Vertical");
        if (horizontal > 0)
        {
            transform.rotation = Quaternion.Euler(0,90,0);
        }
        if (horizontal < 0)
        {
            transform.rotation = Quaternion.Euler(0,-90,0);
        }
        if (vertical > 0)
        {
            transform.rotation = Quaternion.Euler(0,0,0);
        }
        if (vertical < 0)
        {
            transform.rotation = Quaternion.Euler(0,180,0);
        }
    }
}
