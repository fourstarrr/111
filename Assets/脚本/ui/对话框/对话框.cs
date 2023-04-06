using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class 对话框 : MonoBehaviour
{
    public GameObject[] texts;
    public int number;
    void Start()
    {
        
    }   
    void Update()
    {
        if(number!=0&& number != texts.Length)
        {
            texts[number-1].SetActive(false);
            texts[number].SetActive(true);
        }
        else if(number==texts.Length)
        {
            SceneManager.LoadScene("第一章战斗");
        }
    }
    public void addNumber()
    {
        number++;
    }
}
