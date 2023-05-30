using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 血量数字 : MonoBehaviour
{
    private float Hpnow;
    private Text Text;
    private void Start()
    {
        Text = GetComponent<Text>();
        Hpnow = 1;

        
    }

    private void Update()
    {
        Hpnow = GameObject.Find("玩家数据").GetComponent<血量管理>().Hp;
        Text.text = (Hpnow + "/60");
    }
}
