using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float maxTimer = 1;
    private float timer = 0f;
    public GameObject pipe;
    public float minHeight;
    public float maxHeight;

    void Start()
    {
        GameObject newpipe = Instantiate(pipe);
        newpipe.transform.position = transform.position + new Vector3(0, Random.Range(minHeight, maxHeight),0);
    }

    void Update()
    {
        if(timer > maxTimer)
        {
           GameObject newpipe = Instantiate(pipe);
           newpipe.transform.position = transform.position + new Vector3(0, Random.Range(minHeight, maxHeight), 0);
           Destroy(newpipe, 15);
           timer = 0;
        }

        timer += Time.deltaTime;
    }
}
