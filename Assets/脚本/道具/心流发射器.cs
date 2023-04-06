using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 心流发射器 : MonoBehaviour
{
    public GameObject Attack;
    public GameObject Target;
    public float gapTime;
    private float nowTime;
    private Animator animator;
    public GameObject TargetPlace;
    void Start()
    {
        nowTime = gapTime;
        animator = Target.GetComponent<Animator>();
    }

    
    void Update()
    {
        animator.SetFloat("Status",nowTime);
        nowTime +=Time.deltaTime;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ball"&&nowTime > gapTime)
        {
            Debug.Log(1);
            Instantiate(Attack,TargetPlace.transform);
            nowTime = -1;
        }
    }
}
