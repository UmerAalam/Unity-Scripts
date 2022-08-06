using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailEffects : MonoBehaviour
{
    TrailRenderer trailRenderer;

    private void Start()
    {
        trailRenderer = GetComponent<TrailRenderer>();
    }
}
