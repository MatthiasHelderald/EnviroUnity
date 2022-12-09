using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterNavMeshController : MonoBehaviour
{
    public Transform destinationTransform;
    NavMeshAgent agent;
         
        void Update ()
        {
            agent = GetComponent<NavMeshAgent>();
            agent.destination = destinationTransform.position;
            agent.SetDestination(destinationTransform.position);
            
            if(agent.remainingDistance == 0f)
            {
                
            }
            
        }

}
