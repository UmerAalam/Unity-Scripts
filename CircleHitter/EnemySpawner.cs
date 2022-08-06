using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    float timeRate = 1f;
    int spawnDelay = Random.Range(0, 5);

    void Start()
    {
        StartCoroutine(Wait());
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(Random.Range(3,8));
        InvokeRepeating("SpawnEnimies", spawnDelay, timeRate);
    }
    void SpawnEnimies()
    {
        Instantiate(enemy);
    }

}
