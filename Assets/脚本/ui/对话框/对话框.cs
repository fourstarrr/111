using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 对话框 : MonoBehaviour
{
    public GameObject[] texts;
    public int number;
    void Start()
    {
        
    }   
    void Update()
    {
        if(number!=0)
        {
            texts[number-1].SetActive(false);
            texts[number].SetActive(true);
        }
    }
    public void addNumber()
    {
        number++;
    }
}
