using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed = 20;
    public float turnSpeed;

    public Joystick joystick;

    public float horizontalInput;

    Vector3 movement;
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        

        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
    }

 

}