using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomRange : MonoBehaviour
{
    float maxY = 5.53f;
    

    private void Update()
    {
        if(transform.position.y <= -maxY)
        {
            Destroy(gameObject);
        }
    }

}
