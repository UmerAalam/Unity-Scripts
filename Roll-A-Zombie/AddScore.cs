﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    public GameManager gameManager;
    public AudioClip hit;
    AudioSource source;

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        gameManager.AddPoint();
        source.PlayOneShot(hit);
    }
}
