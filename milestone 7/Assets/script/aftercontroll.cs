using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class aftercontroll : MonoBehaviour
{

    public float speed;
    public Rigidbody2D rb;
    public float speedj;
    public bool ok = false;
    public bool okk = false;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    bool FacingRight;

    // Update is called once per frame
    void Update()
    {
        if (ok == true)
        {
                float moveHorizontal = Input.GetAxis("Horizontal");
                rb.velocity = new Vector2(moveHorizontal * speed, rb.velocity.y);
                if (moveHorizontal > 0 && FacingRight)
                {
                    Flip();
                }
                if (moveHorizontal < 0 && !FacingRight)
                {
                    Flip();
                }
            
            if (Input.GetKeyDown(KeyCode.Space) && okk  == true)
            {
                Debug.Log("kud");
                rb.AddForce(Vector2.up * speedj);
                okk = false; 

            }
        }
    }
    void Flip()
    {
        FacingRight = !FacingRight;
        transform.Rotate(0, 180, 0);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       if(collision.collider.CompareTag("land")&& ok == true )
        {
            okk = true;
        }
    }
}
