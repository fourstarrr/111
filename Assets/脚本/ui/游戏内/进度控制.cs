using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 进度控制 : MonoBehaviour
{
    private 怪物生成器 monster;
    private RectTransform rectTransform;
    void Start()
    {
        monster = GameObject.Find("波数控制器").GetComponent<怪物生成器>();
        rectTransform = GetComponent<RectTransform>();
    }

    
    void Update()
    {
        switch(monster.currentWaveNumber)
        {
            case 0:
                rectTransform.anchoredPosition3D = new Vector3(-729, 51, 0);
                break;

            case 1:
                rectTransform.anchoredPosition3D = new Vector3(-600, 51, 0);
                break;
            case 2:
                rectTransform.anchoredPosition3D = new Vector3(-361, 51, 0);
                break;
            case 3:
                rectTransform.anchoredPosition3D = new Vector3(-200, 51, 0);
                break;
            case 4:
                rectTransform.anchoredPosition3D = new Vector3(-5.6f, 51, 0);
                break;
            case 5:
                rectTransform.anchoredPosition3D = new Vector3(170, 51, 0);
                break;
            case 6:
                rectTransform.anchoredPosition3D = new Vector3(326, 51, 0);
                break;
            case 7:
                rectTransform.anchoredPosition3D = new Vector3(636, 51, 0);
                break;

        }
    }
}
