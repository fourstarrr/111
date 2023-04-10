using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class 人物图鉴 : MonoBehaviour
{
    private RectTransform rect;
    void Start()
    {
        rect = GetComponent<RectTransform>();
    }

    
    void Update()
    {
        
        rect.position = rect.position - new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);

    }
}
