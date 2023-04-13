using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 技能3动画 : MonoBehaviour
{
    public GameObject abc;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void Destory()
    {
        transform.position = Vector3.zero;
        abc.SetActive(false);
    }
}
