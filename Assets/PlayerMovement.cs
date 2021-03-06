using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f;
    
    private Vector3 _velocity;
    public Vector3 gravity = new Vector3(0, -9.81f, 0);
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * (speed * Time.deltaTime));

        _velocity += gravity * Time.deltaTime;
        controller.Move(_velocity * Time.deltaTime);
    }
    
    //Detect collisions between the GameObjects with Colliders attached
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "MyGameObjectTag")
        {
            _velocity.y = 0;
        }
    }
}
