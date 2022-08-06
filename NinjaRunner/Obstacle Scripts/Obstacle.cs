using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] float speed = -3f;
    Rigidbody2D myBody;
    float spawnRate;
    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        spawnRate = 0f;
        PlayerPrefs.SetFloat("SpawnRate", 0f);
    }
    void Update()
    {
        spawnRate = PlayerPrefs.GetFloat("SpawnRate");
        myBody.velocity = new Vector2(speed + spawnRate,0);
    }
}
