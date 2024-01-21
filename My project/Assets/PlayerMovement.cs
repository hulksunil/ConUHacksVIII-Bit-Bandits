using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;
    Vector2 movement;
    public Vector2 previousPosition;
    // Update is called once per frame
    void Update()
    {
        //Input

       movement.x = Input.GetAxisRaw("Horizontal");
       movement.y = Input.GetAxisRaw("Vertical");
       animator.SetFloat("Speed", movement.magnitude);
    }

    void FixedUpdate(){
        // Movement

        // -12 is the left most side 
        // -4 is the bottom 
        // 4 is the top

        Debug.Log(rb.position);
        if (!(rb.position.x <= -8.5 || rb.position.y <= -4 || rb.position.y >= 4 || rb.position.x >= 8.5))
        {
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
            previousPosition = rb.position;
        }
        else
        {
            rb.MovePosition(previousPosition);
        }
    }
}
