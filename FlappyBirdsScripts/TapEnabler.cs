using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapEnabler : MonoBehaviour
{
    public GameObject Tap_Enabler;

    void Start()
    {
        Tap_Enabler.SetActive(true); 
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Tap_Enabler.SetActive(false);
        }
    }
}
