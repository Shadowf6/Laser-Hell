using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
    public float maxSpeed;
    private Vector2 velocity, input;

    void Start() 
    {
        transform.position = Vector3.zero;
    }

    void Update() 
    {
        input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;

        if (input != Vector2.zero) 
        {
            velocity = Vector2.MoveTowards(velocity, input * maxSpeed, 100f * Time.deltaTime);
        }
        else 
        {
            velocity = Vector2.MoveTowards(velocity, Vector2.zero, 100f * Time.deltaTime);
        }

        if (velocity.magnitude < 0.01f) 
        {
            velocity = Vector2.zero;
        }

        transform.Translate(velocity * Time.deltaTime);

        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, -8.5f, 8.5f);
        pos.y = Mathf.Clamp(pos.y, -4.7f, 4.7f);

        transform.position = pos;
    }
}
