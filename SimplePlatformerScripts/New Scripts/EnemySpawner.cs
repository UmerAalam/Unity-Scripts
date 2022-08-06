using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemies;
    void Start()
    {
        StartCoroutine(Spawn());
    }

    void Update()
    {
    }
    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(0.5f);
       // int randomChoice = Random.Range(0,8);
        Instantiate(enemies[Random.Range(0,enemies.Length)], new Vector2(15f, transform.position.y), Quaternion.identity);

    }


}
