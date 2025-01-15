using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class enemy_attack : MonoBehaviour
{
    public Animator anim;
    public Collider2D col;


   private void OnTriggerEnter2D(Collider2D other)
   {
    if(other.gameObject.tag == "Player")
    {
        anim.SetBool("attack", true);
    }
   }
    
}
