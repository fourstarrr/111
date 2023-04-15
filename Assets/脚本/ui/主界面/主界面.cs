using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class 主界面 : MonoBehaviour
{

    public GameObject 游戏标题;
    public GameObject 游戏按钮;
    public GameObject 角色档案;
    public GameObject 集团人物关系;
    public GameObject 医师;
    public GameObject 喜;
    public GameObject 陆羽凡;
    private bool isRight = false;
    private int i = 0;

    private void Start()
    {
        
    }
    public void StartGame()
    {
        SceneManager.LoadScene("选关界面");
        PlayAudio();
    }
    public void Setting()
    {
        BackGroundSmall();
        PlayAudio();
        游戏标题.SetActive(false);
        游戏按钮.SetActive(false);
    }
    public void Designer()
    {
      if(!isRight)
        {
            BackLeft();
        }
    }
    public void Back()
    {
        PlayAudio2();
        if (!isRight)
            BackGroundBig();
        else if (isRight)
            BackRight();
    }
    public void Back2()
    {
        PlayAudio2();
        游戏标题.SetActive(true);
        游戏按钮.SetActive(true);
        角色档案.SetActive(false);

    }
    public void Back3()
    {
        PlayAudio2();
        集团人物关系.SetActive(false);
    }
    public void  Back4()
    {
        PlayAudio2();
        医师.SetActive(false);
        陆羽凡.SetActive(false);
        喜.SetActive(false);
    }
   
    public void Enter()
    {
        集团人物关系.SetActive(true);
    }
    public void CharacterChoose1()
    {
        医师.SetActive(true);
    }
    public void CharacterChoose2()
    {
        喜.SetActive(true);
    }
    public void CharacterChoose3()
    {
        陆羽凡.SetActive(true);
    }
    public void Illustrations()
    {
        PlayAudio();
        游戏标题.SetActive(false);
        游戏按钮.SetActive(false);
        角色档案.SetActive(true);

    }
    void  BackGroundSmall()
    {
        if(GameObject.Find("背景").GetComponent<RectTransform>().localScale.x>1)
        {
            GameObject.Find("背景").GetComponent<RectTransform>().localScale = GameObject.Find("背景").GetComponent<RectTransform>().localScale - new Vector3(0.0008f, 0.0008f, 0.0008f);
            GameObject.Find("设置左").GetComponent<RectTransform>().position = GameObject.Find("设置左").GetComponent<RectTransform>().position - new Vector3(-3.36f, 8.64f, 0);
            GameObject.Find("设置右").GetComponent<RectTransform>().position = GameObject.Find("设置右").GetComponent<RectTransform>().position - new Vector3(3.36f, -8.64f, 0);
            GameObject.Find("设置按钮").GetComponent<RectTransform>().position = GameObject.Find("设置按钮").GetComponent<RectTransform>().position - new Vector3(-3.36f, 8.64f, 0);
            Invoke("BackGroundSmall",0.000001f);
            
        }
        else if(GameObject.Find("背景").GetComponent<RectTransform>().localScale.x == 1)
        {
            GameObject.Find("背景").GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
        }
    }
    void BackGroundBig()
    {
        if (GameObject.Find("背景").GetComponent<RectTransform>().localScale.x <1.1f)
        {
            GameObject.Find("背景").GetComponent<RectTransform>().localScale = GameObject.Find("背景").GetComponent<RectTransform>().localScale + new Vector3(0.0008f, 0.0008f, 0.0008f);
            GameObject.Find("设置左").GetComponent<RectTransform>().position = GameObject.Find("设置左").GetComponent<RectTransform>().position + new Vector3(-3.36f, 8.64f, 0);
            GameObject.Find("设置右").GetComponent<RectTransform>().position = GameObject.Find("设置右").GetComponent<RectTransform>().position + new Vector3(3.36f, -8.64f, 0);
            GameObject.Find("设置按钮").GetComponent<RectTransform>().position = GameObject.Find("设置按钮").GetComponent<RectTransform>().position + new Vector3(-3.36f, 8.64f, 0);
            Invoke("BackGroundBig", 0.000001f);

        }
        else if (GameObject.Find("背景").GetComponent<RectTransform>().localScale.x == 1.1f)
        {
            GameObject.Find("背景").GetComponent<RectTransform>().localScale = new Vector3(1.1f, 1.1f, 1.1f);
           游戏标题.SetActive(true);
            游戏按钮.SetActive(true);
        }
    }
    void BackLeft()
    {
        
        if (i<=260)
        {
            GameObject.Find("设置右").GetComponent<RectTransform>().position = GameObject.Find("设置右").GetComponent<RectTransform>().position - new Vector3(4f,0, 0);
            GameObject.Find("设置左").GetComponent<RectTransform>().position = GameObject.Find("设置左").GetComponent<RectTransform>().position - new Vector3(4f, 0, 0);
            i++;
            Invoke("BackLeft", 0.00001f);
        }
        else if(i>260)
        {
            Debug.Log(1);
            //GameObject.Find("设置右").GetComponent<RectTransform>().position = new Vector3(150f, 0, 0);
            isRight = true;
            i = 0;
        }
        
    }
    void BackRight()
    {

        if (i <= 260)
        {
            GameObject.Find("设置右").GetComponent<RectTransform>().position = GameObject.Find("设置右").GetComponent<RectTransform>().position + new Vector3(4f, 0, 0);
            GameObject.Find("设置左").GetComponent<RectTransform>().position = GameObject.Find("设置左").GetComponent<RectTransform>().position + new Vector3(4f, 0, 0);
            i++;
            Invoke("BackRight", 0.00001f);
        }
        else if (i > 260)
        {
            Debug.Log(1);
            //GameObject.Find("设置右").GetComponent<RectTransform>().position = new Vector3(150f, 0, 0);
            isRight = false;
            i = 0;
        }

    }
    void PlayAudio()
    {
        GameObject.Find("选择音效").GetComponent<AudioSource>().Play();
    }
    void PlayAudio2()
    {
        GameObject.Find("选择音效2").GetComponent<AudioSource>().Play();
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
