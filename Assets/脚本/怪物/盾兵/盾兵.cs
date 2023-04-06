using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;

public class 盾兵 : MonoBehaviour
{
    public GameObject 图片;
   
    [Header("攻击范围")]
    public float scope;
    private NavMeshAgent agent;
    private Animator animator;
    private Vector3 finalPosition;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = 图片.GetComponent<Animator>();
        finalPosition = GameObject.Find("弹板").transform.position;
    }


    void Update()
    {
        if (Mathf.Abs(transform.position.x - finalPosition.x + transform.position.z - finalPosition.z) < scope)
        {
            agent.destination = transform.position;
            if (图片.GetComponent<攻击>().timeCheck >= 图片.GetComponent<攻击>().attackGap)
            {
                animator.SetBool("isAttack", true);
            }
        }
        else
        {
            FindFlipper();
        }
    }
    void FindFlipper()
    {
        agent.destination = finalPosition;
    }
}
