using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor.Tilemaps;
using UnityEngine;

public class move : MonoBehaviour
{
    public float moveForce = 3f;
    private float movementX;
    private float maxVelocity=5f;
    private float movementY;
    private Rigidbody2D myBody;
    private SpriteRenderer sr;
    private Animator anim;

    private float isfacingdir=1;
    

      private void Awake(){
        myBody = GetComponent<Rigidbody2D>();
        
        sr = GetComponent<SpriteRenderer>();
        anim=GetComponent<Animator>();

    }



    void Update()
    {
       PlayerMoveKeyboard();
       AnimatePlayer();
       }

    void PlayerMoveKeyboard(){
        movementX = Input.GetAxisRaw("Horizontal");
        movementY =Input.GetAxisRaw("Vertical");
         if(Input.GetKey(KeyCode.LeftShift))
         {
            transform.position += new Vector3(movementX,movementY, 0f) * Time.deltaTime * maxVelocity;
         }
        else{
            transform.position += new Vector3(movementX,movementY, 0f) * Time.deltaTime * moveForce;
        }

    }
    void AnimatePlayer(){
    anim.SetFloat("horizontal",Mathf.Abs(movementX));
    anim.SetFloat("vertical",Mathf.Abs(movementY));
    if(movementX>0 && transform.localScale.x<0 || movementX<0 && transform.localScale.x>0)
    {
        Flip();
     }

    }
    void Flip()
    {
        transform.localScale= new Vector3(transform.localScale.x*-1,transform.localScale.y,transform.localScale.z); 
    }

}
