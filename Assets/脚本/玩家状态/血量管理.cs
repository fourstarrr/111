using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class 血量管理 : MonoBehaviour
{
    public float Hp;
    public GameObject 死亡界面;
    private bool isLoad = false;
    void Start()
    {

    }

    void Update()
    {
        HpCheck();
    }
    void HpCheck()
    {
        if (Hp <= 0 && !isLoad)
        {
            Time.timeScale = 0;
            死亡界面.SetActive(true);
            isLoad = true;
        }
    }
}
