using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    public GameObject a;
    public GameObject b;
    public Rigidbody2D rb;
    public Transform currentposition;
    public float speed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentposition = a.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point = currentposition.position - transform.position;
        if (currentposition== a.transform) 
        { 
         rb.velocity = new Vector2(0, speed);
        
        }else
        {
            rb.velocity = new Vector2(0, -speed);
        }
        if ( Vector2.Distance(transform.position,currentposition.position) <0.5f && currentposition == a.transform)
        {
            currentposition = b.transform;
        }
        if (Vector2.Distance(transform.position, currentposition.position) < 0.5f && currentposition == b.transform)
        {
            currentposition = a.transform;
        }

    }
   
  
    private void OnDrawGizmos()// draw a line to show the way
    {
        Gizmos.DrawLine(a.transform.position, b.transform.position);
    }
}
