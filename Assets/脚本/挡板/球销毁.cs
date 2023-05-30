using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 球销毁 : MonoBehaviour
{
    public GameObject reBornPosition;
    public float damage;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball")
        {
            GameObject.Find("玩家数据").GetComponent<血量管理>().Hp -= damage;
            other.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            other.transform.position = reBornPosition.transform.position;

        }
    }
}
