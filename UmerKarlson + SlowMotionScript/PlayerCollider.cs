using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollider : MonoBehaviour
{
    [SerializeField] float changeColliderTime;
    [SerializeField] GameObject playercol1;
    [SerializeField] GameObject playercol2;

    void Start()
    {
     playercol1.SetActive(true);
     playercol2.SetActive(false);
    }

    void Update()
    {
        SetCollider();
    }
    void SetCollider()
    {
        if(Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
         playercol1.SetActive(false);
         playercol2.SetActive(true);
         StartCoroutine(ChangeCollider());
        }
    }
    IEnumerator ChangeCollider()
    {
        yield return new WaitForSeconds(changeColliderTime);
        
         playercol1.SetActive(true);
         playercol2.SetActive(false);

    }
}
