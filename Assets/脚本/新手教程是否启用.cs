using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 新手教程是否启用 : MonoBehaviour
{
    public GameObject xin;
    void Start()
    {
        if (!GameObject.Find("是否有新手教程(Clone)").GetComponent<是否有新手教程>().hasRead)
        {
            GameObject.Find("是否有新手教程(Clone)").GetComponent<是否有新手教程>().hasRead = true;
            xin.SetActive(true);
        }
        else
        {
            Time.timeScale = 1f;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
