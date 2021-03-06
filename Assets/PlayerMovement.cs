using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    
    public Vector3 velocity;
    public Vector3 gravity = new Vector3(0, -9.81f, 0);
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * (speed * Time.deltaTime));
        
        velocity += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
