using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    Rigidbody targetRb;
    float minForce = 12;
    float maxForce = 16;
    float maxTorque = 10;
    float xRange = 4;
    float yPosition = -6;
    GameManager gameManager;
    public int pointValue;
    public ParticleSystem explosion;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        targetRb = GetComponent<Rigidbody>();
        targetRb.AddForce(RandomForce(),ForceMode.Impulse);
        targetRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);
        transform.position = RandomSpawnPosition();
    }

     void OnMouseDown()
     {
        if (gameManager.isGameActive)
        {
         Destroy(gameObject);
         Instantiate(explosion, transform.position,Quaternion.identity);
         gameManager.UpdateScore(pointValue);
        }
     }
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);

        if (!gameObject.CompareTag("Bad"))
        {
            gameManager.GameOver();
        }
    }


    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minForce, maxForce);
    }
    Vector3 RandomSpawnPosition()
    {
        return new Vector3(Random.Range(-xRange, xRange), yPosition);
    }
    float RandomTorque()
    {
        return Random.Range(-maxTorque, maxTorque);
    }
}
