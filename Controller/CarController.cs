using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(InputManager))]
public class CarController : MonoBehaviour
{
   public InputManager inputManager;
   public List<WheelCollider> throttleWheels;
   public List<WheelCollider> steeringWheels;
   public float forceStrenght = 20000f;
   public float maxTurn = 20f;
   

    void Start()
    {
       inputManager = GetComponent<InputManager>();
    }
    void Update()
    {

    }

    void FixedUpdate()
    {
      foreach (WheelCollider wheel in throttleWheels)
      {
        wheel.motorTorque = forceStrenght * Time.deltaTime * inputManager.throttle;
        throttleWheels.transform.rotation = wheel.motorTorque;
        
      }
      foreach (WheelCollider wheel in steeringWheels)
      {
        wheel.steerAngle = maxTurn * inputManager.steer;
      }

    }
}
