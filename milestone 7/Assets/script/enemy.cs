using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float area;
    public float speed;
    public Transform player;
    public float d;
    public GameObject bullet;
    public GameObject shotpoint;
    public float firerate = 1f;
    private float ready;
    public int maxhealth = 50;
    public int currenthealth ;
    public int damage = 10;
    // Start is called before the first frame update
    void Start()
    {
       currenthealth = maxhealth; 
    }

    // Update is called once per frame
    void Update()
    {
        float dis = Vector2.Distance( player.position,transform.position);
        if (dis<area && dis>d) 
        {
           transform.position = Vector2.MoveTowards(this.transform.position,player.position,speed*Time.deltaTime);        
        }
        else if (dis<d && ready<Time.time) 
        {
            Instantiate(bullet, shotpoint.transform.position,Quaternion.identity);
            ready = Time.time+firerate;
            currenthealth -= damage;

        }
        if(currenthealth < 0)
        {
            Destroy(this.gameObject);
        }
    }
    public void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, area);
        Gizmos.DrawWireSphere (transform.position, d);  
    }
}
