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
    
    public bool enemydied = false;


    void Start()
    {
        player = GameObject.Find("bone_1");
        
        playermovement = GameObject.Find("bone_1").GetComponent<movement1>();
        ruk = this.gameObject.GetComponent<patrol>();
        mat = this.gameObject.GetComponent<playerdetection>();
        chal = this.gameObject.GetComponent<aftercontroll>();
        //j = GameObject.Find("slime_0 1").GetComponents<jump>();

    }


    void Update()
    {
        float dis = Vector2.Distance(player.transform.position, this.gameObject.transform.position);
        if (dis < detectionare && Input.GetKeyDown(KeyCode.E))
        {
           
            control();
            

        }
      
    }
    public void control()
    {
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
   
         void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(this.gameObject.transform.position, detectionare);
        }

}
