using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public float speed = 10;

    void Update()
    {
        transform.Translate(transform.up * -speed * Time.deltaTime);
    }
}
