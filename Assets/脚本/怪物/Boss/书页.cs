using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 书页 : MonoBehaviour
{
    float Boomtime;
    void Start()
    {
        
    }
    private void Awake()
    {
        Boomtime = 0;
    }
    // Update is called once per frame
    void Update()
    {Boomtime+=Time.deltaTime;  
        if (Boomtime > 8)
        {
            GameObject.Find("玩家数据").GetComponent<血量管理>().Hp -= 10;
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            GameObject.Find("Boss").GetComponent<Boss>().Num++;
        Destroy(gameObject);
        }
    }
}
