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

    // Update is called once per frame
    void Update()
    {
        if (ok == true)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            rb.velocity = new Vector2(moveHorizontal * speed, rb.velocity.y);

            if (moveHorizontal>0)
            {
                this.gameObject.transform.localScale = new  Vector3(-1,1,1)* 0.67296f;  
            }else if (moveHorizontal < 0)
            {
                this.gameObject.transform.localScale = new Vector3(1, 1, 1) * 0.67296f;   
            }

            if (Input.GetKeyDown(KeyCode.Space) && okk  == true)
            {
                Debug.Log("kud");
                rb.AddForce(Vector2.up * speedj);
                okk = false; 

            }
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       if(collision.collider.CompareTag("land")&& ok == true )
        {
            okk = true;
        }
    }
}
