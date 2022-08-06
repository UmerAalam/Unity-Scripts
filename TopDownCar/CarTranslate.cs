using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarTranslate : MonoBehaviour
{
    [SerializeField] Rigidbody2D carRb;
    [SerializeField] float checkMoveSpeed, checkRotationSpeed;
    [SerializeField] float linearDrag , gravityScale , angularDrag ;
    float moveSpeed = 5f, rotationSpeed = 5f;
    float move, rotation;
    bool handBrake;
    void Start()
    {
        handBrake = true;
        carRb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        move = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        rotation = Input.GetAxis("Horizontal") * -rotationSpeed * Time.deltaTime;
        HandBrake();
        Rotation();
        Modifiers();
    }
    void Modifiers()
    {
        carRb.gravityScale = gravityScale;
        carRb.drag = linearDrag;
        carRb.angularDrag = angularDrag;
    }
    void FixedUpdate()
    {
        Movement();
    }
    void Movement()
    {
        carRb.AddRelativeForce(Vector2.up.normalized * move,ForceMode2D.Impulse);
    }
    void Rotation()
    {
        transform.Rotate(0f, 0f, rotation);
    }
    void HandBrake()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            handBrake = true;
        }
        if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            handBrake = false;
        }
        if (handBrake == true)
        {
            rotationSpeed = 0f;
            moveSpeed = 0f;
        }
        else
        {
            moveSpeed = checkMoveSpeed;
            rotationSpeed = checkRotationSpeed;
        }
    }
    
    
}
