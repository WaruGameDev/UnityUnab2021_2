using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class FollowPlayerNavMesh : MonoBehaviour
{
    public NavMeshAgent theAgent;

    private void Start()
    {
        Transform player = GameObject.FindGameObjectWithTag("Player").transform;
        theAgent.SetDestination(player.position);
    }

}
