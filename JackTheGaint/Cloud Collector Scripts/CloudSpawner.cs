using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject[] clouds;
    [SerializeField]
    GameObject collectibles;
    GameObject player;

    float distanceBetweenClouds = 3f;
    float minX, maxX;
    float lastCloudPosition;
    float controlX;

    void Awake()
    {
        controlX = 0;
        SetMinAndMaxX();
    }

    void SetMinAndMaxX()
    {
        Vector3 bounds = Camera.main.WorldToScreenPoint(new Vector3(Screen.width, Screen.height, 0));
        maxX = bounds.x - 0.5f;
        minX = -bounds.x + 0.5f;
    }
    void Shuffle(GameObject[] arrayToShuffle)
    {
        for(int i = 0; i < arrayToShuffle.Length; i++)
        {
            GameObject temp = arrayToShuffle[i];
            int random = Random.Range(i, arrayToShuffle.Length);
            arrayToShuffle[i] = arrayToShuffle[random];
            arrayToShuffle[random] = temp;
        }
    }
    void CreateClouds()
    {
        Shuffle(clouds);
        float positionY = 0f;

        for(int i = 0; i < clouds.Length;i++)
        {
            Vector3 temp = clouds[i].transform.position;
            temp.y = positionY;
            temp.x = Random.Range(minX, maxX);
            lastCloudPosition = positionY;
            clouds[i].transform.position = temp;
            positionY -= distanceBetweenClouds;
        }
    }


}
