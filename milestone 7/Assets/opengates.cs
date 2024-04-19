using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opengates : MonoBehaviour
{
    public Transform target;
    public float speed;
    public switchcontroller1 died;
    // Start is called before the first frame update
    void Start()
    {
        died = GameObject.Find("enemy (2)").GetComponent<switchcontroller1>();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    private void OnTriggerStay2D(Collider2D collision)
    {
    
        if (collision.CompareTag("Player")&& died.enemydied == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        
    }
}
