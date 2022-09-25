using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshController : MonoBehaviour
{
    GameObject target;
    NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        target = GameObject.FindWithTag("GameManager").GetComponent<GameManager>().targetPoint;
    }


    private void LateUpdate()
    {
        agent.SetDestination(target.transform.position);
    }
}
