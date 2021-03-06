using System;
using UnityEngine;

public class GroundCollider : MonoBehaviour
{
    public PlayerMovement movement;
    private void OnCollisionEnter(Collision collision)
    {
        movement.velocity.y = 0;
        movement.gravity.y = 0;
    }

    private void OnCollisionExit(Collision other)
    {
        movement.gravity.y = -9.81f;
    }
}