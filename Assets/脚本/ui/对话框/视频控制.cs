using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class 视频控制 : MonoBehaviour
{
    private float time1;
    public GameObject first;
    public GameObject button;
    public int timeEnd;
    public int type;
    //public GameObject second;
    private void Awake()
    {
        //second.SetActive(false);
        time1 = 0;
    }
    private void Update()
    {
        time1+= Time.deltaTime;
        if (type == 0)
        {
            if (time1 >= timeEnd)
            {
                button.SetActive(true);
                first.SetActive(true);
                gameObject.SetActive(false);
               
            }
        }
        else if(type == 1)
        {
            if (time1 >= timeEnd)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            }
        }
    }
}
