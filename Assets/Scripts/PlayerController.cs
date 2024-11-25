using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float startSpeed = 1f;
    public float maxSpeed = 6f;
    private float accel = (float)(1 / 12);
    private float decel = (float)(1 / 6);
    private Vector2 velocity;

    private void Update()
    {
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if (input != Vector2.zero) // If input is pressed
        {
            velocity = Vector2.MoveTowards(velocity, input * maxSpeed, accel * Time.deltaTime);
        } else 
        {
            velocity = Vector2.MoveTowards(velocity, Vector2.zero, decel * Time.deltaTime);
        }

        transform.position += (Vector3)velocity * Time.deltaTime;
    }
}
