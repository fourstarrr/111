using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadChange : MonoBehaviour
{
    public float timeCheck;
    private Animator _animator;
    public bool isBegin;
    void Start()
    {
        isBegin = false;
        _animator = GetComponent<Animator>();
    }

    public void Begin()
    {
        _animator.SetBool("isBegin", true);
    }

}
