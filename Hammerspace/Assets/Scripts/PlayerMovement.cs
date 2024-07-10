using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of the player

    private Rigidbody2D rb;
    private Vector2 movement;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Get input from keyboard
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        // Normalize the vector to prevent faster diagonal movement
        movement = new Vector2(moveX, moveY).normalized;
    }

    void FixedUpdate()
    {
        // Apply movement to the Rigidbody2D
        rb.velocity = movement * moveSpeed;
    }
}
