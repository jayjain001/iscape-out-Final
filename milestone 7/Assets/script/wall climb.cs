using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class wallclimb : MonoBehaviour
{
    private float horizontal;
    private float speed = 10f;
    private float jumpPower = 16f;

    private bool isWallSliding = false;
    private float wallSlidingSpeed = 2f; // change it accourding to your needs.

    private bool isWallClimbing;
    private float wallClimbingSpeed = 5f;// change it accourding to your needs.

    [SerializeField] private Rigidbody2D rb;


    // just copy and paste these two line if you are adding more Groundcheck;
    [SerializeField] private Transform groundcheck;
    [SerializeField] private LayerMask groundLayer;

    // just copy and paste these two line if you are adding more wallcheck;
    [SerializeField] private Transform wallcheck;
    [SerializeField] private LayerMask wallLayer;

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
        else
        {
            rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
        }
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundcheck.position, 1f, groundLayer); // DEFAULT VALUE: 0.2F BUT I AM CHANING IT BCS i AM USING A WHOLE CIRLCE.
    }

    private bool IsWalled()
    {
        return Physics2D.OverlapCircle(wallcheck.position, 1f, wallLayer); // change it accourding to your needs.
    }

    private void WallSlide()
    {
        if (IsWalled()&& IsGrounded() && horizontal != 0f && !isWallClimbing)
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
