using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Character;
public class 球 : MonoBehaviour
{
    [Header("重力大小")]
    [Tooltip("模拟重力，用来调试手感，球会一直朝屏幕下方移动")]
    public float gravity;
    [Header("攻击伤害")]
    public float damage;
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
            collision.gameObject.GetComponent<挂在怪物身上的属性>().enemyCurrentHealth -= damage;
        }
    }
}
