using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class 字幕 : MonoBehaviour
{
    string str;
    TMP_Text tex;
    int i = 0;
    int index = 0;
    string str1 = "";
    bool ison = true;

    void Start()
    {
       tex = GetComponent<TMP_Text>();
        str = tex.text;
        tex.text = "";
        i = 70;
    }

    // Update is called once per frame
    void Update()
    {
        if (ison)
        {
            i -= 1;
            if (i <= 0)
            {
                if(index>= str.Length)
                {
                    ison = false;
                    return;
                }
                str1 = str1 + str[index].ToString();
                tex.text = str1;
                index += 1;
                i = 70;
            }
        }
    }
}
