using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedText : MonoBehaviour
{
    [SerializeField] Vector3 fixedPosition;
    void Update()
    {

        transform.position = new Vector3(fixedPosition.x,fixedPosition.y,fixedPosition.z);
    }
}
