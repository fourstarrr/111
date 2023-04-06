using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 视频控制 : MonoBehaviour
{
    private float time1;
    public GameObject first;
    //public GameObject second;
    private void Awake()
    {
        //second.SetActive(false);
        time1 = 0;
    }
    private void Update()
    {
        time1+= Time.deltaTime;
        if (time1 >= 36)
        {
           first.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
