using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    public float speedj =2;
    public Rigidbody2D rb;
    public bool rukja;
    public bool okk;
   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rukja == true) 
        
        {

         if (Input.GetKeyDown(KeyCode.Space) && okk == true)
         {
            Debug.Log("kud");
            rb.AddForce(Vector2.up * speedj);
            okk = false;
 
         }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("land"))
        {
            okk = true; 
        }
    }
}
