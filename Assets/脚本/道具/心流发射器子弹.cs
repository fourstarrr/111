using Character;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 心流发射器子弹 : MonoBehaviour
{
    public float damage;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            other.GetComponent<挂在怪物身上的属性>().enemyCurrentHealth -= damage;
        }
        if(other.gameObject.layer == 10)
        {
            Destroy(gameObject);
        }
    }
}
