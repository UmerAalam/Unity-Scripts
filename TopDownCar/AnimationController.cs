using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator carAnim;
    int animatioinChanger = 0;
    bool isTurn;


    void Start()
    {
        isTurn = false;
        carAnim = GetComponent<Animator>();
    }

    void Update()
    {
        ControlAnimation();
        InputForAnimation();
    }
    void InputForAnimation()
    {
        float horizontal = Input.GetAxis("Horizontal");
        if (horizontal < 0 && isTurn)
        {
            animatioinChanger = 1;
            isTurn = false;
        }
        if (horizontal > 0 && !isTurn)
        {
            animatioinChanger = 3;
            isTurn = true;
        }
        if (horizontal == 0)
        {
            animatioinChanger = 2;
        }

        if (isTurn)
        {
            if (horizontal == 0)
            {
                animatioinChanger = 4;
            }
        }
        

    }
    void ControlAnimation()
    {
        carAnim.SetInteger("SetAnimation", animatioinChanger);
    }
    
}
