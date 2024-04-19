using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shift : MonoBehaviour
{
    public GameObject cango;
    public float speed;
    public switchcontroller1 control;
   
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && control.enemydied == true)
        { 
        this.transform.position = Vector2.MoveTowards(this.transform.position, cango.transform.position, speed * Time.deltaTime);
        }
    }
}
