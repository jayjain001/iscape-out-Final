using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    private float speed = 10f;
    private float jumpPower = 16f;

    private bool isWallSliding = false;
    private float wallSlidingSpeed = 2f; // change it accourding to your needs.

    private bool isWallClimbing;
    [SerializeField] float wallClimbingSpeed ;// change it accourding to your needs.

    [SerializeField] private Rigidbody2D rb;


   
  
    // just copy and paste these two line if you are adding more wallcheck;
    [SerializeField] private Transform wallcheck;
    [SerializeField] private LayerMask wallLayer;


    private void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
         
    }
    void Update()
    {

        WallSlide();

        if (IsWalled() && Input.GetKey(KeyCode.LeftShift))
        {
            isWallClimbing = true;
        }
        else
        {
            isWallClimbing = false;
        }

    }

    private void FixedUpdate()
    {
        if (isWallClimbing)
        {
            rb.velocity = new Vector2(rb.velocity.x, Input.GetAxis("Vertical") * wallClimbingSpeed);

        }
        
    }

  

    private bool IsWalled()
    {
        return Physics2D.OverlapCircle(this.gameObject.transform.position, .2f, wallLayer); // change it accourding to your needs.
    }

    private void WallSlide()
    {
        if (IsWalled()  && !isWallClimbing)
        {
            isWallSliding = true;
            rb.velocity = new Vector2(rb.velocity.x, Mathf.Clamp(rb.velocity.y, -wallSlidingSpeed, float.MaxValue));
        }
        else
        {
            isWallSliding = false;
        }
    }
}

