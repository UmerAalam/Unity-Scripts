using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    [SerializeField] private float objectSpeed;
    private float resetPosition = 42.8f;

    void Update()
    {
        transform.Translate(Vector3.left * (objectSpeed * Time.deltaTime));
        if(transform.localPosition.x >= resetPosition)
        {
            Vector3 newPos = new Vector3(-84.39f, transform.position.y, transform.position.z);
            transform.position = newPos;
        }
    }
}
