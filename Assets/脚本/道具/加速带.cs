using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 加速带 : MonoBehaviour
{ public float speedUp;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Ball")
        {
            other.gameObject.GetComponent<Rigidbody>().velocity  = other.gameObject.GetComponent<Rigidbody>().velocity*speedUp;
        }
    }
}
