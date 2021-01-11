using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float enemyRange = 5f;

    NavMeshAgent navMeshAgent;
    float distanceToTarget;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        distanceToTarget = Vector3.Distance(target.position, transform.position);
        if (distanceToTarget < enemyRange)
        {
            navMeshAgent.SetDestination(target.position);
        }
    }
}
