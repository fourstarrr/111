using Character;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class 技能2 : MonoBehaviour
{
    public float damage;
    public float time;
    private void Update()
    {
        time += Time.deltaTime;
        
        if (time > 5)
        {
            GameObject.Find("技能2特效").SetActive(false);
            gameObject.SetActive(false);
        }
    }
   
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Enemy")
        {
            other.gameObject.GetComponent<挂在怪物身上的属性>().enemyCurrentHealth -= damage;
        }
    }
}
