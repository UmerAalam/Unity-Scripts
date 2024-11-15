﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    [SerializeField] GameObject[] obstacles;
    [SerializeField] List<GameObject> obstaclesForSpawning;


    private void Awake()
    {
        InitializeGameObjects();
    }

    void Start()
    {
        StartCoroutine(SpawnRandomObstacles());
    }

    void InitializeGameObjects()
    {
        int index = 0;
        for (int i = 0; i < obstacles.Length * 3; i++)
        {
            GameObject obj = Instantiate(obstacles[index], new Vector3(transform.position.x, transform.position.y, -2), Quaternion.identity) as GameObject;
            obstaclesForSpawning.Add(obj);
            obstaclesForSpawning[i].SetActive(false);
            index++;
            if (index == obstacles.Length)
            {
                index = 0;
            }

        }
    }
    void Shuffle()
    {
        for (int i = 0; i < obstaclesForSpawning.Count; i++)
        {
            GameObject temp = obstaclesForSpawning[i];
            int random = Random.Range(i, obstaclesForSpawning.Count);
            obstaclesForSpawning[i] = obstaclesForSpawning[random];
            obstaclesForSpawning[random] = temp;
        }

    }
    IEnumerator SpawnRandomObstacles()
    {
        yield return new WaitForSeconds(Random.Range(1.5f, 4.5f));
        int index = Random.Range(0, obstaclesForSpawning.Count);

        while(true)
        {
            if (!obstaclesForSpawning[index].activeInHierarchy)
            {
                obstaclesForSpawning[index].SetActive(true);
                obstaclesForSpawning[index].transform.position = new Vector3(transform.position.x,transform.position.y,-2);
                break;
            }
            else
            {
                index = Random.Range(0, obstaclesForSpawning.Count);
            }
        }
        StartCoroutine(SpawnRandomObstacles());
        
    }

}
