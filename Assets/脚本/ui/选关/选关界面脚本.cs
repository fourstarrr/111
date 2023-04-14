using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class 选关界面脚本 : MonoBehaviour
{
    public GameObject wenan1;
    public GameObject wenan2;

    public void Button1()
    {
        wenan1.SetActive(true);
        wenan2.SetActive(false);
    }
    public void Button2()
    {
        wenan1.SetActive(false);
        wenan2.SetActive(true);
    }
    public void Enter1()
    {
        SceneManager.LoadScene("第一章前对话");
    }
    public void Enter2()
    {
        SceneManager.LoadScene("第二章前对话");
    }
    public void Back()
    {
        SceneManager.LoadScene("游戏主界面");
    }
}
