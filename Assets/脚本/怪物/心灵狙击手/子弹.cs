using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 子弹 : MonoBehaviour
{
    [Header("子弹伤害")]
    public int damage;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Flipper")
        {
            GameObject.Find("玩家数据").GetComponent<血量管理>().Hp -= damage;
            Destroy(gameObject);
        }
    }
}
