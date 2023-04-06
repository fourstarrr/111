using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 攻击 : MonoBehaviour

{
    [Header("攻击伤害")]
    public float damage;
    private Animator animator;
    public GameObject game1;
    [Header("攻击间隔")]
    public float attackGap;
    public float timeCheck;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        timeCheck += Time.deltaTime;
    }
    public void Attack()
    {
        GameObject.Find("玩家数据").GetComponent<血量管理>().Hp -= damage;
        timeCheck = 0;
        animator.SetBool("isAttack", false);
    }
    public void Stop()
    {
        animator.SetBool("isAttack", false);
    }
    public void Death()
    { 
        Destroy(game1);
    }
}
