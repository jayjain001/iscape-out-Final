using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class switchcontroller1 : MonoBehaviour
{

    public movement1 playermovement;
    public jump j;
    public patrol ruk;
    public GameObject player;
    public float detectionare;
    public playerdetection mat;
    public aftercontroll chal;
    
    public bool enemydied = false;


    void Start()
    {
        player = GameObject.Find("bone_1");
        
        playermovement = GameObject.Find("bone_1").GetComponent<movement1>();
        ruk = this.gameObject.GetComponent<patrol>();
        mat = this.gameObject.GetComponent<playerdetection>();
        chal = this.gameObject.GetComponent<aftercontroll>();
        j = this .gameObject.GetComponent<jump>();

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
        j.canjump = false;
    } 
   
         void OnDrawGizmosSelected()
        {
            Gizmos.DrawWireSphere(this.gameObject.transform.position, detectionare);
            Gizmos.color = Color.yellow;
        }

}
