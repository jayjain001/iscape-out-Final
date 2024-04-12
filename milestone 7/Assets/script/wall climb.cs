using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class wallclimb : MonoBehaviour
{
    public float verticle;
    public float climbspeed;
    public bool isclimbing;
    public bool onwall;
    public BoxCollider2D boxCollider;
    [SerializeField] Rigidbody2D rb;

    private void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();     
    }


    // Update is called once per frame
    void Update()
    {
        verticle = Input.GetAxis("verticle");
        if(isclimbing&& Mathf.Abs(verticle) > 0f)
        {
            isclimbing = true;
        }   
    }
    private void FixedUpdate()
    {
        if(isclimbing == true)
        {
            rb.gravityScale = 0f;
            rb.velocity = new Vector2 (rb.velocity.x,verticle*climbspeed);
        }
        else
        {
            rb.gravityScale = 5F;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("climb"))
        {
            onwall = true;  
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("climb"))
        {
            onwall= false;
            isclimbing = false;
        }
    }
}
