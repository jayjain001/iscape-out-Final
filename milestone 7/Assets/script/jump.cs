using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public float jumping = 1f;
    public float speedj =2;
    public Rigidbody2D rb;
    public bool canjump = true;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space)&& canjump == true )
        {
            rb.AddForce(new Vector2(transform.position.x, jumping * speedj));
            canjump = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("land"))
        {
            canjump = true;
        }
    }
}
