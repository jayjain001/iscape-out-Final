using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class switchcontroller1 : MonoBehaviour
{

    public movement1 playermovement;
    public jump[] j;
    public patrol ruk;
    public GameObject player;
    public float detectionare;
    public playerdetection mat;
    public aftercontroll chal;
    public Animator ani;
    private bool oncontrol = false;
    public bool enemydied = false;
    public int sec;
    public Vector3 offset;
    public GameObject  doit;

    void Start()
    {
        player = GameObject.Find("bone_1");
        
        playermovement = GameObject.Find("bone_1").GetComponent<movement1>();
        ruk = this.gameObject.GetComponent<patrol>();
        mat = this.gameObject.GetComponent<playerdetection>();
        chal = this.gameObject.GetComponent<aftercontroll>();
        doit = GameObject.Find("cancont");
        

    }


    void Update()
    {
        float dis = Vector2.Distance(player.transform.position, doit.transform.position );
        if (dis < detectionare && Input.GetKeyDown(KeyCode.E) && enemydied == false)
        {
           
            control();


        }
        if(oncontrol == true)
        {
            Invoke("d", 5f);
        }
        
        
       
        
    }
    public void control()
    {
        oncontrol = true;
        playermovement.canmove = false;
        ruk.kar = false;
        mat.kar = false;
        chal.ok = true;
        ani.SetBool("detected",false);
        for(int i=0;i<= j.Length;i++)
        {
            j[i].rukja = false;
        }
       
    } 
   
         void OnDrawGizmos()
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(doit.transform.position , detectionare);
        }
    public  void d()
    {
        enemydied = true;   
        Destroy(this.gameObject);
        playermovement.canmove = true;
        for (int i = 0; i <= j.Length - 1; i++)
        {
            j[i].rukja = true;
        }
    }
  
  
}
