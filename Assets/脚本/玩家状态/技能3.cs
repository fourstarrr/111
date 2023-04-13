using Character;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 技能3 : MonoBehaviour
{
    public float damage;
 
    void Start()
    {
        
    }

  
    void Update()
    {
       
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.tag  == "Enemy")
        {
            other.GetComponent<挂在怪物身上的属性>().enemyCurrentHealth -= damage;
        }
    }
}
