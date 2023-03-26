using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Character
{
    /// <summary>
    /// 怪物本体属性信息
    /// 用于控制伤害死亡等
    /// </summary>
    public class 挂在怪物身上的属性 : MonoBehaviour
    {
        [Header("此处放入对应的怪物的数据")]
        public 怪物属性基类 CharactersInfo;
        [SerializeField] public float enemyCurrentHealth;
        [SerializeField] public float enemyCurrentDamage;
        [SerializeField] public float enemyCurrentProperties;

        public GameObject 图片;

        void Awake()
        {   //游戏开始数据初始化
            enemyCurrentHealth = CharactersInfo.MaxHealth;
            enemyCurrentDamage = CharactersInfo.AttackDamge;
            enemyCurrentProperties = CharactersInfo.Properties;

        }


        void Update()
        {
            Death();
        }
        void Death()
        { //生命值归0死亡
            if (enemyCurrentHealth <= 0)
            {
                图片.GetComponent<Animator>().SetBool("isDeath", true);
                
            }
        }
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Flipper")
            {//碰到挡板之后死亡并且摧毁单位
                GameObject.Find("玩家数据").GetComponent<血量管理>().Hp -= enemyCurrentDamage;
                Destroy(gameObject);
            }
        }
    }
}