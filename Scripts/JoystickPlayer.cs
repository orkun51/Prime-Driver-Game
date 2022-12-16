using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickPlayer : MonoBehaviour
{
    private float speed = 60;
    private float verticalSpeed = 50;
    
    public FloatingJoystick variableJoystick;
    public Rigidbody rb;

    
    public void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * verticalSpeed);
        Vector3 direction =  Vector3.right * variableJoystick.Horizontal;

        //Vector3.forward * variableJoystick.Vertical +
        rb.AddForce(direction * speed * Time.fixedDeltaTime, ForceMode.VelocityChange);
    }
   
}