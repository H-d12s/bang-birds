using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using Unity.VisualScripting;
using UnityEditor.Tilemaps;
using UnityEngine;
using UnityEngine.Tilemaps;

public class enemy_chase : MonoBehaviour
{public Rigidbody2D rb;
private Transform player;
public float speed=4;
private bool ischasing=false;
private int facingdir=1;
private Animator anim;
private GameObject[] tileObjects;
private TilemapCollider2D tilecol;
private Vector2 direction;

    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        anim=GetComponent<Animator>();
         tileObjects = GameObject.FindGameObjectsWithTag("overcomr");

        foreach (GameObject tileObject in tileObjects)
        {
            // Get the Tilemap component from each object
            tilecol = tileObject.GetComponent<TilemapCollider2D>();
            
    
    }}

    
    void Update()
    {if(ischasing)
        { animateplayer(1);
            
        chase();
    }
    else{
        animateplayer(2);
    }
    }
    void chase()
    {
        if(player.position.x>transform.position.x &&facingdir==-1||player.position.x<transform.position.x && facingdir==1)
            {Flip();}
           
        
           
            direction=(player.position-transform.position).normalized;
             rb.velocity = direction*speed;
             
        
             
    }

    void Flip()
    {
        facingdir*=-1;
        transform.localScale=new Vector3(transform.localScale.x*-1,transform.localScale.y,transform.localScale.z);
    }
        
    
    private void OnTriggerEnter2D(Collider2D collision)
    {if(collision.gameObject.tag=="Player")
        {
            if(player==null)
            {
                player=collision.transform;
            }
            ischasing=true;
        }
    }
      private void OnTriggerExit2D(Collider2D collision)
    {if(collision.gameObject.tag=="Player")
        {   rb.velocity = Vector2.zero; 
            ischasing=false;}
    }

    void animateplayer(int state)
    {
        if(state==1)
        {
            anim.SetBool("walk",true);
            anim.SetBool("idle",false);
        }
        else if(state==2)
        {
            anim.SetBool("walk",false);
            anim.SetBool("idle",true);
        }
        

    }
}
