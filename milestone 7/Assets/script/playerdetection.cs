using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerdetection : MonoBehaviour
{
    public float speed;
    public LayerMask p;
    public Transform target;
    public float dis;
    public Animator anim;
    public bool kar = true;
       void Start()
    {
        Physics2D.queriesStartInColliders = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (kar == true)
        {

           RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right, dis);
        /* if (hit.collider == null)
          {
            anim.SetBool(("detected"), false);
          }
            else if (hit.collider.CompareTag("Player"))
          {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed* Time.deltaTime);
            anim.SetBool(("detected"),true);
          }*/
           if(hit.collider != null)
            {
            Debug.DrawRay(transform.position, transform.right * dis, Color.red);
                if (hit.collider.CompareTag("Player"))
                {
                    transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
                    anim.SetBool(("detected"), true);
                }
            }
            else
            {
                anim.SetBool(("detected"), false);
                Debug.DrawRay(transform.position, transform.right * dis, Color.green);
            }
        }
        
    }
}
