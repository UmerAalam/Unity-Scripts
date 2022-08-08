using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] GameObject player;
    [SerializeField] GameObject platform;

    [SerializeField] float minX, maxX, minY, maxY,lerpTime = 1.5f;
    float lerpX;
    bool cameraLerp;

    void Start()
    {
        MakeInstance();
        CreateInitialPlatform();
    }
    void MakeInstance()
    {
        if (instance == null)
            instance = this;
    }
    private void Update()
    {
        if(cameraLerp)
        {
            LerpTheCamera();
        }
    }
    void CreateInitialPlatform()
    {
        Vector3 pos = new Vector3(Random.Range(minX,minX + 1.2f),Random.Range(minY,maxY),0);
        Instantiate(platform, pos, Quaternion.identity);
        pos.y = 2f;
        Instantiate(player, pos, Quaternion.identity);
        pos = new Vector3(Random.Range(maxX, maxX - 1.2f), Random.Range(minY, maxY), 0);
        Instantiate(platform, pos, Quaternion.identity);

    }
    void LerpTheCamera()
    {
        float cameraX = Camera.main.transform.position.x;
        cameraX = Mathf.Lerp(cameraX,lerpX,lerpTime * Time.deltaTime);
        Camera.main.transform.position = new Vector3(cameraX,Camera.main.transform.position.y,Camera.main.transform.position.z);
    }
    public  void CreateNewPlatformAndLerp(float lerpPosition)
    {
        CreateNewPlatfrom();

        lerpX = lerpPosition + maxX;
        cameraLerp = true;
    }
    void CreateNewPlatfrom()
    {
        float cameraX = Camera.main.transform.position.x;
        float newMaxX = (maxX * 2) + cameraX;
        Instantiate(platform, new Vector3(Random.Range(newMaxX, newMaxX - 1.2f), Random.Range(maxY, maxY - 1.2f),0), Quaternion.identity);
    }

}
