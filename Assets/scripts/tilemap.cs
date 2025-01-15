using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class tilemap : MonoBehaviour
{
 public Collider2D[] mountaincolliders;
 public Collider2D[] boundarycolliders;


 private void OnTriggerEnter2D(Collider2D collision)
 {if(collision.gameObject.tag == "Player"){
    foreach (Collider2D mountain in mountaincolliders)
    {
        mountain.enabled = false;
       
    }
    foreach(Collider2D boundary in boundarycolliders)
    {
        boundary.enabled=true;
    }
   
       collision.gameObject.GetComponent<SpriteRenderer>().sortingOrder=15;

    
 }

 }
}
