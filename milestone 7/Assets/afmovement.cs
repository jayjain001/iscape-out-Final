using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class afmovement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    public float speedj;
    public bool canmove = true ;
   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canmove == true) 
        {
        float moveHorizontal = Input.GetAxis("Horizontal");
            rb.velocity = new Vector2(moveHorizontal * speed, rb.velocity.y);


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("kud");
           rb.AddForce(Vector2.up*speedj);
        
        }
        }

       
       
    }
}
