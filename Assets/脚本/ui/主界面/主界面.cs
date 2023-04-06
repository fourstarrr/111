using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class 主界面 : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("第一章前对话");
    }
}
