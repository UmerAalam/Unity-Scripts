using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingSpawner : MonoBehaviour
{
    // All Circles at one place.
    public GameObject[] Circles;
    //Spawner Transform for getting position.
    public Transform spawner;
    //Position.
    Vector3 pos;
    //Score Integer

    void Update()
    {
        pos = new Vector3(0, spawner.transform.position.y , 0);
    }



   public IEnumerator SpawnCircle()
    {
        Debug.Log("Done");
        yield return new WaitForSeconds(0.5f);
        int random = Random.Range(0, 3);
        Instantiate(Circles[random],pos, Quaternion.identity);
    }

}
