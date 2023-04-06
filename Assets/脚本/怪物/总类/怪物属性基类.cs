using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Character
{
    /// <summary>
    /// 怪物属性信息
    /// 用于批量制作怪物数据
    /// </summary>
    [CreateAssetMenu(menuName = "ScriptableObjects/EnemyCharacterStatusInfo")]
    public class 怪物属性基类 : ScriptableObject
    {


        //攻击力
        [SerializeField] private float attackDamge;
        public float AttackDamge => attackDamge;
        //生命值
        [SerializeField] private float maxHealth;
        public float MaxHealth => maxHealth;
        //属性
        [Tooltip("1是喜，2是哀，3是怒")]
        [SerializeField] private int properties;
        public int Properties => properties;

    }
}