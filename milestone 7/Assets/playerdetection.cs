using System.Collections;
using System.Collections.Generic;
using System.Net;
using Unity.Burst.CompilerServices;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class playerdetection : MonoBehaviour
{
    public float speed;
    public LayerMask p;
    private RaycastHit2D hit;
    public Transform target;
    public float dis;
    public Animator anim;
    public bool kar = true;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (kar == true)
        {

        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right, dis,p);
        Debug.DrawRay(transform.position, transform.right * dis, Color.red);
        if (hit.collider == null)
        {
            anim.SetBool(("detected"), false);
        }
            else if (hit.collider.CompareTag("Player"))
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed* Time.deltaTime);
            anim.SetBool(("detected"),true);
        }
        }
    }
}
