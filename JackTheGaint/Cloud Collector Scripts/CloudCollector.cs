using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudCollector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Cloud" || collision.gameObject.tag == "Deadly")
        {
            collision.gameObject.SetActive(false);
        }
    }
}
