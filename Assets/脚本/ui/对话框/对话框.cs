using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class 对话框 : MonoBehaviour
{
    public GameObject[] texts;
    public int number;
    public GameObject vedio2;
    void Start()
    {
        
    }   
    void Update()
    {
        if(number!=0&& number != texts.Length-1)
        {
            texts[number-1].SetActive(false);
            texts[number].SetActive(true);
        }
        else if(number==texts.Length)
        {          
        }
    }
    public void addNumber()
    {
        if( number != texts.Length-1)
        {
            number++;

        }
        else if (number == texts.Length-1)
        {
            texts[number-1].SetActive(false);
            vedio2.SetActive(true);
        }    
    }
}
