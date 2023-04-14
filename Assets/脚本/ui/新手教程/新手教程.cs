using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 新手教程 : MonoBehaviour
{
    public GameObject a1;
    public GameObject a2;
    public GameObject a3;
    public GameObject a4;
    public GameObject a5;
    public GameObject a6;
    public GameObject a7;
    public GameObject a8;
    public GameObject a9;
    public GameObject a10;
    public GameObject a11;
   
    void Start()
    {
        Time.timeScale = 0f;
    }

    
   public void Next1()
    {
        a1.SetActive(false);
        a2.SetActive(true);
    }
    public void Next2()
    {
        a2.SetActive(false);
        a3.SetActive(true);
    }
    public void Next3()
    {
        a3.SetActive(false);
        a4.SetActive(true);
    }
    public void Next4()
    {
        a4.SetActive(false);
        a5.SetActive(true);
    }
    public void Next5()
    {
        a5.SetActive(false);
        a6.SetActive(true);
    }
    public void Next6()
    {
        a6.SetActive(false);
        a7.SetActive(true);
    }
    public void Next7()
    {
        a7.SetActive(false);
        a8.SetActive(true);
    }
    public void Next8()
    {
        a8.SetActive(false);
        a9.SetActive(true);
    }
    public void Next9()
    {
        a9.SetActive(false);
        a10.SetActive(true);
    }
    public void Next10()
    {
        a10.SetActive(false);
        a11.SetActive(true);
    }
    public void Next11()
    {
        a11.SetActive(false);

        Time.timeScale = 1f;
    }
}
