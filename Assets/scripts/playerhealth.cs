using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using TMPro;

public class playerhealth : MonoBehaviour
{public int currenthealth=5;
public int maxhealth=5;

public TMP_Text healthtext;
public Animator textanim;

void  Start()
{
    healthtext.text="HP:"+currenthealth+"/"+maxhealth;
}
public void ChangeHealth(int damage)
{
    currenthealth+=damage;
    textanim.Play("text");
    healthtext.text="HP:"+currenthealth+"/"+maxhealth;
    if(currenthealth<=0)
    {
        gameObject.SetActive(false);
    }
}

}
