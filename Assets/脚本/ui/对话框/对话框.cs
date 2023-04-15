using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class 对话框 : MonoBehaviour
{
    public int sceneNumber;
    public GameObject[] texts;
    public int number;
    public GameObject vedio2;
    void Start()
    {
        
    }   
    void Update()
    {
        if(number!=0&& number != texts.Length-1&&sceneNumber ==1)
        {
            texts[number-1].SetActive(false);
            texts[number].SetActive(true);
        }
        else if(number != 0 && number != texts.Length && sceneNumber == 2)
        {
            texts[number - 1].SetActive(false);
            texts[number].SetActive(true);
        }
        else if (number != 0 && number != texts.Length && sceneNumber == 3)
        {
            texts[number - 1].SetActive(false);
            texts[number].SetActive(true);
        }
    }
    public void addNumber()
    {
        PlayAudio();
        if ( number != texts.Length-1)
        {
            number++;

        }
        else if (number == texts.Length-1&&sceneNumber ==1)
        {
            texts[number-1].SetActive(false);
            GameObject.Find("音频控制").SetActive(false);
            vedio2.SetActive(true);
        }
        else if (number == texts.Length - 1 && sceneNumber == 2)
        {
            SceneManager.LoadScene("选关界面");
        }
        else if (number == texts.Length - 1 && sceneNumber == 3)
        {
            SceneManager.LoadScene("第二章战斗");
        }
    }
    void PlayAudio()
    {
        GameObject.Find("选择音效").GetComponent<AudioSource>().Play();
    }
}
