using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class 心灵狙击手 : MonoBehaviour
{
    public GameObject 图片;

    [Header("攻击范围")]
    public float scope;
    [Header("攻击间隔")]
    public float attackGap;
    private NavMeshAgent agent;
    private Animator animator;
    private Vector3 finalPosition;
    private float time;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = 图片.GetComponent<Animator>();
        finalPosition = GameObject.Find("Target").transform.position;
    }
    private void Awake()
    {
        time = 0;
    }

    void Update()
    {
        TimeCheck();
        if (Mathf.Abs(transform.position.x - finalPosition.x + transform.position.z - finalPosition.z) < scope&&time>=attackGap)
        {
            agent.destination = transform.position;
            animator.SetBool("isAttack", true);
            time = 0;
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
    void TimeCheck()
    {
        time += Time.deltaTime;
    }
    public void Death()
    {
        Destroy(gameObject);
    }
}
