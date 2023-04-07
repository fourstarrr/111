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
        GameObject.Find("技能1").GetComponent<Image>().fillAmount = skill1NowGap / skill1Gap;
        GameObject.Find("技能2").GetComponent<Image>().fillAmount = skill2NowGap / skill2Gap;
        GameObject.Find("技能3").GetComponent<Image>().fillAmount = skill3NowGap / skill3Gap;
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

    }
    void Skill3()
    {

    }

}
