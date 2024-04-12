using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class crouch : MonoBehaviour

{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.C)) 
        {
            anim.SetBool(("iscrouch"), true);
        }
        else
        {
            anim.SetBool(("iscrouch"), false);

        }
    }
}
