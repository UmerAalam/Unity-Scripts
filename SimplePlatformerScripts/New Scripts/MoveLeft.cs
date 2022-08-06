using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speedX = 1f;
    void Update()
    {
        transform.Translate(new Vector3(speedX,transform.position.y));
    }
}
