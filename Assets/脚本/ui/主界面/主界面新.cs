using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class 主界面新 : MonoBehaviour
{
    public GameObject 还没做好;
    public void noDo()
    {
        还没做好.SetActive(true);
    }
    public GameObject 制作人员名单;
    public GameObject 按钮父物体;
   public void openMaker()
    {
        按钮父物体.SetActive(false);
        制作人员名单.SetActive(true);
    }
    public void backMaker()
    {
        制作人员名单.SetActive(false );
        按钮父物体.SetActive(true);       
    }
    public GameObject 新游戏按钮;
    public void startGame()
    {
        按钮父物体.SetActive(false);
        新游戏按钮.SetActive(true);
    }
    public void backStartGame()
    {
        新游戏按钮.SetActive(false);
        按钮父物体.SetActive(true);
    }

    public void newGame()
    {
        SceneManager.LoadScene("肉鸽界面");
    }
    public void storyMode()
    {
        SceneManager.LoadScene("选关界面");
    }
    public void setting()
    {
        SceneManager.LoadScene("设置界面");
    }
    public void settingBack()
    {
        SceneManager.LoadScene(0);
    }
    public void come()
    {
        SceneManager.LoadScene("游戏图鉴");
    }
    public void comeBack()
    {
        SceneManager.LoadScene(0);
    }
    public GameObject 角色图鉴;
    public GameObject 敌人图鉴;
    public GameObject 主控;
    public void openCharacter()
    {
        主控.SetActive(false);
        角色图鉴.SetActive(true);
    }
    public void closeCharacter()
    {
        角色图鉴.SetActive(false);
        主控.SetActive(true);
    }
    public GameObject 医师;
    public void openDocter()
    {
        医师.SetActive(true);
        角色图鉴.SetActive(false);
    }
    public void closeDocter()
    {
        医师.SetActive(false);
        角色图鉴.SetActive(true);
    }
    public GameObject 喜;
    public void openXi()
    {
        喜.SetActive(true);
        角色图鉴.SetActive(false);
    }
    public void closeXi()
    {
        喜.SetActive(false);
        角色图鉴.SetActive(true);
    }
    public GameObject 主管;
    public void openZhuguan()
    {
       主管.SetActive(true);
        角色图鉴.SetActive(false);
    }
    public void closeZhuguan()
    {
        主管.SetActive(false);
        角色图鉴.SetActive(true);
    }
    public GameObject 故事;
    public void openStory()
    {
        故事.SetActive(true);
        角色图鉴.SetActive(false);
    }
    public void closeStory()
    {
        故事.SetActive(false);
        角色图鉴.SetActive(true);
    }
    public GameObject 陆羽凡;
    public void openLin()
    {
        故事.SetActive(false);
        陆羽凡 .SetActive(true);
    }
    public void closeLin()
    {
        故事.SetActive(true);
        陆羽凡 .SetActive(false);
    }
    public GameObject 信息, 信息1, 信息2;
    private int num = 1;
    public void textUp()
    {
        num++;
        if(num>=3)
        {
            num = 3;
        }
        switch(num)
        {
            case 1:
                信息.SetActive(true);
                信息1.SetActive(false);
                信息2.SetActive(false);
                break;
            case 2:
                信息.SetActive(false);
                信息1.SetActive(true);
                信息2.SetActive(false);
                break;
            case 3:
                信息.SetActive(false);
                信息1.SetActive(false);
                信息2.SetActive(true);
                break;
        }
    }
    public void textDown()
    {
        num--;
        if (num <= 1)
        {
            num = 1;
        }
        switch (num)
        {
            case 1:
                信息.SetActive(true);
                信息1.SetActive(false);
                信息2.SetActive(false);
                break;
            case 2:
                信息.SetActive(false);
                信息1.SetActive(true);
                信息2.SetActive(false);
                break;
            case 3:
                信息.SetActive(false);
                信息1.SetActive(false);
                信息2.SetActive(true);
                break;
        }
    }
    
    public void enemyBack()
    {
        主控.SetActive(true);
        敌人图鉴.SetActive(false);
    }
    public void enemyOpen()
    {
        主控.SetActive(false);
        敌人图鉴.SetActive(true);
    }
    public GameObject 小型心魔;
    public GameObject 普通心魔;
    public GameObject 持盾心魔;
    public GameObject 心灵狙击手;
    public GameObject Boss1;

    public void openEnemy1()
    {
        小型心魔.SetActive(true);
        普通心魔.SetActive(false);
        持盾心魔.SetActive(false);
        心灵狙击手.SetActive(false);
    }
    public void openEnemy2()
    {
        小型心魔.SetActive(false);
        普通心魔.SetActive(true);
        持盾心魔.SetActive(false);
        心灵狙击手.SetActive(false);
    }
    public void openEnemy3()
    {
        小型心魔.SetActive(false);
        普通心魔.SetActive(false);
        持盾心魔.SetActive(true);
        心灵狙击手.SetActive(false);
    }

    public void openEnemy4()
    {
        小型心魔.SetActive(false);
        普通心魔.SetActive(false);
        持盾心魔.SetActive(false);
        心灵狙击手.SetActive(true);
    }

    public void Boss()
    {
        Boss1.SetActive(true);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
