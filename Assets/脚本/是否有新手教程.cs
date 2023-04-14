using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 是否有新手教程 : MonoBehaviour
{
    public bool hasRead = false;
   void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
        DontDestroyOnLoad(gameObject);
        
    }
}
