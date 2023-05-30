using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bosspicture : MonoBehaviour
{
    public GameObject father;
    void Attack()
    {
        father.GetComponent<Boss>().Attack();
    }
}
