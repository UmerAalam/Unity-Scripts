using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [HideInInspector] public float throttle;
    [HideInInspector] public float steer;
    [HideInInspector] public float steerAnim;
    [SerializeField] public Animator carAnim;

    void Start()
    {
        carAnim = GetComponent<Animator>();
    }

    void Update()
    {
        SetAnimations();
        throttle = Input.GetAxis("Vertical");
        steer = Input.GetAxis("Horizontal");
        steerAnim = Input.GetAxisRaw("Horizontal");
    }

    void SetAnimations()
    {
        if (steerAnim > 0)
        {
            carAnim.SetInteger("TurnRight",1);
            carAnim.SetInteger("TurnLeft",2);
        }
        if (steerAnim < 0)
        {
            carAnim.SetInteger("TurnLeft",1);
            carAnim.SetInteger("TurnRight",2);
        }
        
        if (steerAnim == 0)
        {
            carAnim.SetInteger("TurnRight",2);
            carAnim.SetInteger("TurnLeft",2);
        }
    }
}
