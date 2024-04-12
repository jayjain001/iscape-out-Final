using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using Unity.VisualScripting;
using UnityEngine;

public class patrol : MonoBehaviour
{
    public float speed;
    public bool right = false;
    public float dis;
    public LayerMask aa;
    public bool kar = true;
  
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (kar == true)
        {

        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right, dis,aa);
        Debug.DrawRay(transform.position,transform.right*dis, Color.blue);
      
        
        transform.Translate (Vector2.right *speed*Time.deltaTime);
        if(hit.collider == null )
        {
           
        }else if (hit.collider.CompareTag("wall") )
        {   
            transform.Rotate(0, 180, 0);
        } 
        }
        
    }
}
