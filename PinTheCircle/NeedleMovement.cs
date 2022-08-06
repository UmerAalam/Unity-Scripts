using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedleMovement : MonoBehaviour
{
    [SerializeField] GameObject needleBody;
    [SerializeField] float forceY = 70f;
    Rigidbody2D needleRb;
    bool canFireNeedle = false;
    bool touchedTheCirlce;

    void Awake()
    {
        Initialize();
    }
    void Initialize()
    {
        needleBody.SetActive(false);
        needleRb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
      if(canFireNeedle)
      {
            needleRb.velocity = new Vector2(0,forceY);
      }
      else
      {
            needleRb.velocity = new Vector2(0,0);
      }
    }
    public void FireTheNeedle()
    {
        needleBody.SetActive(true);
        needleRb.isKinematic = false;
        canFireNeedle = true;
    }
    private void OnTriggerEnter2D(Collider2D target)
    {
        if (touchedTheCirlce)
            return;

        if(target.CompareTag("Circle"))
        {
            canFireNeedle = false;
            touchedTheCirlce = true;
            needleRb.isKinematic = true;
            gameObject.transform.SetParent(target.transform);
        }
    }

}
