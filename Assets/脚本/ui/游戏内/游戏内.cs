using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class 游戏内 : MonoBehaviour
{
    public GameObject 暂停界面;
   public void JustStop()
    {
        PlayAudio2();
        Time.timeScale = 0;
        暂停界面.SetActive(true);
    }
    public void Countinue()
    {
        PlayAudio2();
        Time.timeScale = 1;
        暂停界面.SetActive(false);
    }
    public void ReTry()
    {
        PlayAudio2();
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void ReturnMain()
    {
        PlayAudio2();
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    void PlayAudio2()
    {
        GameObject.Find("UI音效").GetComponent<AudioSource>().Play();
    }
}
