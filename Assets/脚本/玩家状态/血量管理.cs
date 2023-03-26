using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class 血量管理 : MonoBehaviour
{
    public float Hp;

    void Start()
    {

    }

    void Update()
    {
        HpCheck();
    }
    void HpCheck()
    {
        if (Hp <= 0)
        {
            SceneManager.LoadScene("失败界面");
        }
    }
}
