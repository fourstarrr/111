using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 技能 : MonoBehaviour
{
    public float skill1Gap;
    public float skill2Gap;

    public float skill3Gap;
    public float skill1NowGap;
    public float skill2NowGap;
    public float skill3NowGap;

    public GameObject 状态1;
    public GameObject 状态2;
    public GameObject 状态3;

    public GameObject 技能2;
    public GameObject 技能3;
    public GameObject 技能3动画;
    void Start()
    {
        skill1NowGap = skill1Gap;
        skill2NowGap = skill2Gap;
        skill3NowGap = skill3Gap;
    }

    
    void Update()
    {
        TimeUp();
        CD();
       if( Input.GetKeyDown(KeyCode.Q)&&skill1NowGap>=skill1Gap)
       {
            skill1NowGap = 0;
            Skill1();
        }
       else if( Input.GetKeyDown(KeyCode.W)&&skill2NowGap>=skill2Gap)
        {
            skill2NowGap = 0;
            Skill2();
        }
       else if(Input.GetKeyDown(KeyCode.E)&&skill3NowGap>=skill3Gap)
        {
            skill3NowGap = 0;
            Skill3();
        }
    }
   void TimeUp()
    {
        skill1NowGap+=Time.deltaTime;
        skill2NowGap += Time.deltaTime;
        skill3NowGap += Time.deltaTime;
    }
    private void CD()
    {
        GameObject.Find("技能111").GetComponent<Image>().fillAmount = 1-skill1NowGap / skill1Gap;
        GameObject.Find("技能222").GetComponent<Image>().fillAmount =1- skill2NowGap / skill2Gap;
        GameObject.Find("技能333").GetComponent<Image>().fillAmount =1- skill3NowGap / skill3Gap;
        switch (GameObject.Find("球").GetComponent<球>().properties)
        {
            case 0:
                状态1.SetActive(false);
                状态2.SetActive(false);
                状态3.SetActive(false);
                break;
            case 1:
                状态1.SetActive(true);
                状态2.SetActive(false);
                状态3.SetActive(false);
                break;
            case 2:
                状态1.SetActive(false);
                状态2.SetActive(true);
                状态3.SetActive(false);
                break;
            case 3:
                状态1.SetActive(false);
                状态2.SetActive(false);
                状态3.SetActive(true);
                break;

        }
    }
    void Skill1()
    {
        if (GameObject.Find("球").GetComponent<球>().properties <= 3)
        { GameObject.Find("球").GetComponent<球>().properties++; }
        else
        { GameObject.Find("球").GetComponent<球>().properties = 1; }

    }
    void Skill2()
    {
        技能2.SetActive(true);
        技能2.GetComponent<技能2>().time = 0;
    }
    void Skill3()
    {
        技能3动画.SetActive(true);
        技能3.SetActive(true);
        技能3.GetComponent<技能3>().time = 0;
    }

}
