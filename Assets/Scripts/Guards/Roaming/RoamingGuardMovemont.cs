using System;
using UnityEngine;
using UnityEngine.AI;

namespace Guards.Roaming
{
    public class RoamingGuardMovemont : MonoBehaviour
    {
        private NavMeshAgent navMesh;
        private GuardFOV guardFOV;
        private void Start()
        {
            navMesh = GetComponent<NavMeshAgent>();
            guardFOV = GetComponent<GuardFOV>();
        }

        private void FixedUpdate()
        {
            if (guardFOV.canSeePlayer)
            {
                navMesh.SetDestination(guardFOV.player.transform.position);
            }
            else
            {
                navMesh.SetDestination(transform.position);
            }
        }
    }
}
