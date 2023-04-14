using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class 游戏内 : MonoBehaviour
{
    public GameObject 暂停界面;
   public void JustStop()
    {
        Time.timeScale = 0;
        暂停界面.SetActive(true);
    }
    public void Countinue()
    {
        Time.timeScale = 1;
        暂停界面.SetActive(false);
    }
    public void ReTry()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void ReturnMain()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
