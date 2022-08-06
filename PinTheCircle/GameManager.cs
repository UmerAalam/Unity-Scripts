using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField] Button shootBtn;
    [SerializeField] GameObject needle;
    [SerializeField] int howManyNeedles;
    [SerializeField] float distanceInNeedles;
    GameObject[] gameneedles;
    int needleIndex;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        GetButton();
    }
    private void Start()
    {
        CreateNeedles();
    }
    private void GetButton()
    {
        shootBtn.onClick.AddListener(() => ShootTheNeedle());
    }
    public void ShootTheNeedle()
    {
        gameneedles[needleIndex].GetComponent<NeedleMovement>().FireTheNeedle();
        needleIndex++;

        if(needleIndex == gameneedles.Length)
        {
            Debug.Log("The Game is Finished");
            shootBtn.onClick.RemoveAllListeners();
        }
    }
    void CreateNeedles()
    {
        gameneedles = new GameObject[howManyNeedles];
        Vector3 temp = transform.position;

        for(int i = 0;i < gameneedles.Length; i++)
        {
            gameneedles[i] = Instantiate(needle,temp,Quaternion.identity) as GameObject;
            temp.y -= distanceInNeedles;
        }
    }
}
