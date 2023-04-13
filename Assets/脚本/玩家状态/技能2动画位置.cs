using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 技能2动画位置 : MonoBehaviour
{
    private Transform abc;
    void Start()
    {
        abc = GameObject.Find("球").GetComponent<Transform>();
    }


    void Update()
    {
        transform.position = abc.position;
    }

}
