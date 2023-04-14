using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 加载判断脚本 : MonoBehaviour
{
    public GameObject abc;
    void Start()
    {
        if(GameObject.Find("是否有新手教程(Clone)") == null)
        {
            Instantiate(abc);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
