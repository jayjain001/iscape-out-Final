using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement1 : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    [SerializeField] float cr;
  
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


        /* if (Input.GetKey(KeyCode.LeftShift))
         {


            transform.localScale -= new Vector3(0, 0, 0f) * Time.deltaTime;
            transform.localScale = Vector3.Min(transform.localScale, new Vector3(cr,cr,0f));
         }

         if (Input.GetKeyUp(KeyCode.LeftShift))
         {
            transform.localScale += new Vector3(0, 0, 0f) * Time.deltaTime;
            transform.localScale = Vector3.Max(transform.localScale, new Vector3(1, 1, 1));
            
         }*/
        }
    }
   
}
