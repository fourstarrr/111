using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathBegin : MonoBehaviour
{
    public GameObject[] balance = new GameObject[8];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Role")
        {
            for(int i = 0; i < balance.Length; i++) 
            {
                balance[i].GetComponent<RoadChange>().Begin();
            }
        }
    }
}
