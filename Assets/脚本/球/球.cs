using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Character;
using UnityEngine.UI;
using UnityEngine.AI;

public class 球 : MonoBehaviour
{
    [Header("重力大小")]
    [Tooltip("模拟重力，用来调试手感，球会一直朝屏幕下方移动")]
    public float gravity;
    [Header("攻击伤害")]
    public float damage;
    [Header("击退力度")]
    public float addforce;
    [Header("属性")]
    public int properties = 0;
    private Rigidbody rb;
    private float realGravity;

    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        Vector3 gravityDirection = new Vector3(0, 0, -1);
        rb.AddForce(gravityDirection * gravity);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            ContactPoint[] contactPoints = collision.contacts;
            foreach (ContactPoint contactPoint in contactPoints)
            {
                Vector3 normal = contactPoint.normal;
                Vector3 force = -normal * addforce;
                collision.gameObject.GetComponent<Rigidbody>().AddForce(force, ForceMode.Impulse);
                Debug.Log(1);
            }
            switch(collision.gameObject.GetComponent<挂在怪物身上的属性>().enemyCurrentProperties)
            {
                case 1: switch(properties)
                    {
                        case 0: 
                            collision.gameObject.GetComponent<挂在怪物身上的属性>().enemyCurrentHealth -= damage;
                            if (rb != null)
                            {
                                rb.AddExplosionForce(addforce, transform.position, 3, 2);
                                //Debug.Log("explosion");
                            }
                            break;
                            case 1:
                            collision.gameObject.GetComponent<挂在怪物身上的属性>().enemyCurrentHealth -= damage;
                            if (rb != null)
                            {
                                rb.AddExplosionForce(addforce, transform.position, 3, 2);
                                //Debug.Log("explosion");
                            }
                            break;
                        case 2:
                            collision.gameObject.GetComponent<挂在怪物身上的属性>().enemyCurrentHealth -= damage;
                            if (rb != null)
                            {
                                rb.AddExplosionForce(addforce, transform.position, 3, 2);
                                //Debug.Log("explosion");
                            }
                            break;
                        case 3:
                            collision.gameObject.GetComponent<挂在怪物身上的属性>().enemyCurrentHealth -= damage*1.5f;
                            if (rb != null)
                            {
                                rb.AddExplosionForce(addforce, transform.position, 3, 2);
                                //Debug.Log("explosion");
                            }
                            break;
                    }
                    break;
                case 2:
                    switch (properties)
                    {
                        case 0:
                            collision.gameObject.GetComponent<挂在怪物身上的属性>().enemyCurrentHealth -= damage;
                            if (rb != null)
                            {
                                rb.AddExplosionForce(addforce, transform.position, 3, 2);
                                //Debug.Log("explosion");
                            }
                            break;
                        case 1:
                            collision.gameObject.GetComponent<挂在怪物身上的属性>().enemyCurrentHealth -= damage;
                            if (rb != null)
                            {
                                rb.AddExplosionForce(addforce*1.2f, transform.position, 3, 2);
                                //Debug.Log("explosion");
                            }
                            break;
                        case 2:
                            collision.gameObject.GetComponent<挂在怪物身上的属性>().enemyCurrentHealth -= damage;
                            if (rb != null)
                            {
                                rb.AddExplosionForce(addforce, transform.position, 3, 2);
                                //Debug.Log("explosion");
                            }
                            break;
                        case 3:
                            collision.gameObject.GetComponent<挂在怪物身上的属性>().enemyCurrentHealth -= damage * 1.5f;
                            if (rb != null)
                            {
                                rb.AddExplosionForce(addforce, transform.position, 3, 2);
                                //Debug.Log("explosion");
                            }
                            break;
                    }
                    break;
                case 3:
                    switch (properties)
                    {
                        case 0:
                            collision.gameObject.GetComponent<挂在怪物身上的属性>().enemyCurrentHealth -= damage;
                            if (rb != null)
                            {
                                rb.AddExplosionForce(addforce, transform.position, 3, 2);
                                //Debug.Log("explosion");
                            }
                            break;
                        case 1:
                            collision.gameObject.GetComponent<挂在怪物身上的属性>().enemyCurrentHealth -= damage;
                            if (rb != null)
                            {
                                rb.AddExplosionForce(addforce, transform.position, 3, 2);
                                //Debug.Log("explosion");
                            }
                            break;
                        case 2:
                            collision.gameObject.GetComponent<挂在怪物身上的属性>().enemyCurrentHealth -= damage;
                            if (rb != null)
                            {
                                rb.AddExplosionForce(addforce, transform.position, 3, 2);
                                if (!collision.gameObject.GetComponent<挂在怪物身上的属性>().isSlow)
                                {
                                    collision.gameObject.GetComponent<NavMeshAgent>().speed = collision.gameObject.GetComponent<NavMeshAgent>().speed * 0.6f;
                                    collision.gameObject.GetComponent<挂在怪物身上的属性>().isSlow = true;
                                        }
                                //Debug.Log("explosion");
                            }
                            break;
                        case 3:
                            collision.gameObject.GetComponent<挂在怪物身上的属性>().enemyCurrentHealth -= damage * 1.5f;
                            if (rb != null)
                            {
                                rb.AddExplosionForce(addforce, transform.position, 3, 2);
                                //Debug.Log("explosion");
                            }
                            break;
                    }
                    break;
            }
           // collision.gameObject.GetComponent<挂在怪物身上的属性>().enemyCurrentHealth -= damage;
        }
    }
}
