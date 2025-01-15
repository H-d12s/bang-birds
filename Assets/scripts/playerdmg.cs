using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerdmg : MonoBehaviour
{
    public playerhealth health;
    public int damage =1;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "lowenemy")
        {
            health.ChangeHealth(-damage);
        }
    }

}
