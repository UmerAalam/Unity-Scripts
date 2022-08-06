using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaximumY : MonoBehaviour
{
    
    void Update()
    {
        maximumY(-11f,10.8f);
        Movement(5f);
    }
    void Movement(float downwardSpeed)
    {
        transform.Translate(new Vector2(0, -downwardSpeed * Time.deltaTime));
    }
    void maximumY(float maxY,float spawnPosition)
    {
        if(transform.position.y <= maxY)
        {
            transform.position = new Vector2(0, spawnPosition);
        }
    }
}
