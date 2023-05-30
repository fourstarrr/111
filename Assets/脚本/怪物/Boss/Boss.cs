using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Boss : MonoBehaviour
{
    public GameObject position1;
    public GameObject position2;
    public float attackgap;
    private float nowgap;

    private float moveTimeCheck;

    private NavMeshAgent nav;
    public GameObject AttackPrefab;
    public GameObject[] Tatget;
    private Rigidbody rb;
    public GameObject picture;
    private Animator animator;
    public int Num;
    private void Start()
    {
       // nav = GetComponent<NavMeshAgent>();
        rb = GetComponent<Rigidbody>();
        animator =picture.GetComponent<Animator>();
        //nav.destination = position1.transform.position;
        Attack();
    }
    private void Update()
    {
        TimeCheck();
       // Movement();
        Attack2();
        if(Num>=15)
        {
            SceneManager.LoadScene(8);
            Destroy(gameObject);
        }
    }
    void Attack2()
    {

        if(nowgap>attackgap)
        {
            animator.SetBool("isAttack", true);
        }
    }
    void TimeCheck()
    {
        moveTimeCheck += Time.deltaTime;
        nowgap += Time.deltaTime;
    }
    void Movement()
    {
        if(Vector3.Distance(gameObject.transform.position,position1.transform.position)<=10)
        {
            if(moveTimeCheck>=10)
            {
               
                nav.destination = position2.transform.position;
                moveTimeCheck=0;
            }          
        }
        else if(Vector3.Distance(gameObject.transform.position, position2.transform.position) <= 10)
        {
            if (moveTimeCheck >= 10)
            {
              
                nav.destination = position1.transform.position;
                moveTimeCheck = 0;
            }
        }
    }

  public  void Attack()
    {
        Instantiate(AttackPrefab, Tatget[0].transform);
        Instantiate(AttackPrefab, Tatget[1].transform);
        Instantiate(AttackPrefab, Tatget[2].transform);
        nowgap = 0;
        animator.SetBool("isAttack", false);
    }
}
