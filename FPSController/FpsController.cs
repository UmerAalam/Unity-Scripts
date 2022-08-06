using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FpsController : MonoBehaviour
{
    [SerializeField] float sensitivity;
    [SerializeField] Transform player;
    float xRotation = 0f;

     void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; 
    }

    void Update()
    {
      float mouseX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
      float mouseY = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation,0f,0f);
        transform.Rotate(Vector3.up * mouseX);
    }
}
