using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class grappling : MonoBehaviour
{
 

    public float grapplingDistance = 10f;
   

    private LineRenderer lineRenderer;
    private DistanceJoint2D joint;
    private Vector3 targetPosition;
    private RaycastHit2D hit;
    public Camera cam;
    public Rigidbody2D box;
    public float grapplelegnth;
     

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        joint = GetComponent<DistanceJoint2D>();
        joint.enabled = false;
        lineRenderer.enabled = false;
        box = GameObject.FindGameObjectWithTag("box").GetComponent<Rigidbody2D>();
       
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            StartGrapple();
           
        }
        else if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            StopGrapple();
        }

        if (joint.enabled)
        {
            lineRenderer.SetPosition(0, transform.position);
            lineRenderer.SetPosition(1, targetPosition);
        }
        else
        {

        }
    }

    void StartGrapple()
    {
        hit = Physics2D.Raycast(transform.position, cam.ScreenToWorldPoint(Input.mousePosition) - transform.position, grapplingDistance);

        if (hit.collider != null)
        {
        Debug.DrawRay(transform.position, (cam.ScreenToWorldPoint(Input.mousePosition)  -transform.position) * grapplingDistance);
           if(hit.collider.CompareTag("grap"))
            {

            joint.enabled = true;
            lineRenderer.enabled = true;
            joint.connectedAnchor = hit.point;
            targetPosition = hit.point;
            joint.distance = grapplelegnth;
            }
        if (hit.collider.CompareTag("lever"))
        {
                joint.enabled = true;
                lineRenderer.enabled = true;
                joint.connectedAnchor = hit.point;
                targetPosition = hit.point;
                joint.distance = grapplelegnth;
                box.gravityScale = 2f;
            hit.collider.GetComponent<leverdown>().Caught = true;

        }
        
        }
       
       
        

    }
     

    void StopGrapple()
    {
        joint.enabled = false;
        lineRenderer.enabled = false;
    }
   
}






