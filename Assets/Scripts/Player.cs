using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Joystick joystick;
    public Transform football,self;
    public Rigidbody footballBody;
    private float distance, horizontal, vertical, speed = 500.0f;
    // Update is called once per frame
    void FixedUpdate()
    {
        speed = 500.0f;
        GetDistance();
        GetInput();
        if (distance < 15)
        {
            Shoot();
        }
        if(footballBody.velocity.magnitude < 1.5)
        {
            Reset();
        }
    }

    void GetDistance()
    {
        distance = Vector3.Distance(football.transform.position, self.transform.position);
    }

    void GetInput()
    {
        horizontal = 0;
        vertical = 0;
        horizontal = joystick.Horizontal;
        vertical = joystick.Vertical;
    }

    void Shoot()
    {
        Vector3 movement = new Vector3(horizontal, vertical, 0.0f);
        footballBody.AddForce(movement * speed);
    }

    public void Reset()
    {
        football.position = new Vector3(0, 0, -5);
        footballBody.velocity = new Vector3(0, 0, 0);
    }
}
