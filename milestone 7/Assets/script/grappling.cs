using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grappling : MonoBehaviour
{
 

    public float grapplingDistance = 10f;
    public LayerMask grapplingLayerMask;

    private LineRenderer lineRenderer;
    private DistanceJoint2D joint;
    private Vector3 targetPosition;
    private RaycastHit2D hit;
    public Camera cam;
     

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        joint = GetComponent<DistanceJoint2D>();
        joint.enabled = false;
        lineRenderer.enabled = false;
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
    }

    void StartGrapple()
    {
        hit = Physics2D.Raycast(transform.position, cam.ScreenToWorldPoint(Input.mousePosition) - transform.position, grapplingDistance, grapplingLayerMask);
        Debug.DrawRay(transform.position, (cam.ScreenToWorldPoint(Input.mousePosition)  -transform.position) * grapplingDistance);

        if (hit.collider != null)
        {
            joint.enabled = true;
            lineRenderer.enabled = true;
            joint.connectedAnchor = hit.point;
            targetPosition = hit.point;
        }
       
    }

    void StopGrapple()
    {
        joint.enabled = false;
        lineRenderer.enabled = false;
    }
   
}






