using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerhealth : MonoBehaviour
{
    public int health = 1;
   
    
   
    void Start()
    {
    
    }
    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
       
            Invoke("pdie", 1f);

        }

    }
    public void pdie()
    {
        Destroy(this.gameObject);
      
    }
}
