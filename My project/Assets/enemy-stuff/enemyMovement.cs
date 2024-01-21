using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMovement : MonoBehaviour
{

    public float moveSpeed = 8f;

    public Rigidbody2D rb;
    Vector2 movement;


   void Update()
    {
        //Input

       movement.x = -1;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // rb.velocity = transform.left * moveSpeed;
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

    }
}
