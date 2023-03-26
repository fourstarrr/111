using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 攻击 : MonoBehaviour

{
    [Header("攻击伤害")]
    public float damage;
    private Animator animator;
    public GameObject game1;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Attack()
    {
        GameObject.Find("玩家数据").GetComponent<血量管理>().Hp -= damage;
        animator.SetBool("isAttack", false);
    }

    public void Death()
    { 
        Destroy(game1);
    }
}
