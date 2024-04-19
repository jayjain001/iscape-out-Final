using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leverdown : MonoBehaviour
{
    public bool Caught;
    public Animator anim;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Caught)
        {
            anim.SetTrigger("on 0");
            Caught = false;
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
    }

    public void FalseThis()
    {
        anim.enabled = false;
    }
}
