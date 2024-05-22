using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Path: MonoBehaviour
{
    private NavMeshAgent agent;
    public GameObject finalPlace;
    private Vector3 targetPosition;
 
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        targetPosition = finalPlace.transform.position;
    }

    void Update()
    {
        FindTarget();
    }
    void FindTarget()
    {
        agent.destination = targetPosition;
    }
}
