using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 波数现实 : MonoBehaviour
{
    private 怪物生成器 monster;
    private float distance;
    private RectTransform rectl;
    void Start()
    {
        monster = GameObject.Find("波数控制器").GetComponent<怪物生成器>();
        rectl = GetComponent<RectTransform>();
        distance = 1340 / monster.waves.Length;
    }

    
    void Update()
    {
        switch(monster.currentWaveNumber)
        {
             case 0:
                 rectl.anchoredPosition = new Vector3(-740, 45, 0);
                 break;
             case 1:
                 rectl.anchoredPosition = new Vector3(-549,45,0);
                 break;
             case 2:
                 rectl.anchoredPosition = new Vector3(-370,45, 0);
                 break;
             case 3:
                 rectl.anchoredPosition = new Vector3(-167, 45, 0);
                 break;
             case 4:
                 rectl.anchoredPosition = new Vector3(-13, 45, 0);
                 break;
             case 5:
                 rectl.anchoredPosition = new Vector3(215, 45, 0);
                 break;
             case 6:
                 rectl.anchoredPosition = new Vector3(316, 45, 0);
                 break;

             case 7:
                 rectl.anchoredPosition = new Vector3(627,45, 0);
                 break;
        }
        
    }
}
