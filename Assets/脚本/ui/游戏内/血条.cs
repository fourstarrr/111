using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 血条 : MonoBehaviour
{
    private float fullHP;
    private float nowHP;
    private Image Image;
    void Start()
    {
        fullHP = GameObject.Find("玩家数据").GetComponent<血量管理>().Hp;
        Image = GetComponent<Image>();
        Image.fillAmount = 1;
    }

    
    void Update()
    {
        nowHP = GameObject.Find("玩家数据").GetComponent<血量管理>().Hp;
        Image.fillAmount = nowHP / fullHP;
    }
}
