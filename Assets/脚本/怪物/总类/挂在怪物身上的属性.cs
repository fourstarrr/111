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
        public float addForce;
        [Header("此处放入对应的怪物的数据")]
        public 怪物属性基类 CharactersInfo;
        [SerializeField] public float enemyCurrentHealth;
        [SerializeField] public float enemyCurrentDamage;
        [SerializeField] public float enemyCurrentProperties;
        public bool isSlow = false;

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
            ContactPoint[] contactPoints = collision.contacts;
            
            if (collision.gameObject.CompareTag("Ball"))
            {
GameObject.Find("Main Camera").GetComponent<屏幕震动>().isShakeCamera = true;
                foreach (ContactPoint contactPoint in contactPoints)
                {
                    Vector3 normal = contactPoint.normal;
                    Vector3 force = -normal * addForce;
                    collision.gameObject.GetComponent<Rigidbody>().velocity = force;
                }
            }
        }
    }
}