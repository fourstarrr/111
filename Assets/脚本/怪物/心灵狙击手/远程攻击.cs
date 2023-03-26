using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 远程攻击 : MonoBehaviour
{
    [Header("攻击伤害")]
    public float damage;
    private Animator animator;
    public GameObject attackprefab;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void Attack()
    {
        float X, Z;

        X = GameObject.Find("弹板").transform.position.x - transform.position.x;
        Z = GameObject.Find("弹板").transform.position.z - transform.position.z;
        Vector3 direction = new Vector3(X, 0, Z);
        direction.Normalize();
        GameObject attack = Instantiate(attackprefab);
        attack.transform.position = transform.position;
        attack.GetComponent<Rigidbody>().AddForce(direction * 50);
        animator.SetBool("isAtaack", false);
    }
    public void Death() 
    {
        Destroy(gameObject);
    }
}
