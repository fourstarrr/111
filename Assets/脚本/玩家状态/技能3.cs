using Character;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 技能3 : MonoBehaviour
{
    public float damage;
    public float time;
    void Start()
    {
        
    }

  
    void Update()
    {
        time += Time.deltaTime;
        if(time>0.2)
        {
            gameObject.SetActive(false);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.tag  == "Enemy")
        {
            other.GetComponent<挂在怪物身上的属性>().enemyCurrentHealth -= damage;
        }
    }
}
