using System;
using UnityEngine;
using UnityEngine.AI;

namespace Guards.Roaming
{
    public class RoamingGuardMovemont : MonoBehaviour
    {
        private NavMeshAgent navMesh;
        private GuardFOV guardFOV;
        private General_interactions.Bribe bribe; 
        private void Start()
        {
            navMesh = GetComponent<NavMeshAgent>();
            guardFOV = GetComponent<GuardFOV>();
            bribe = GetComponent<General_interactions.Bribe>();
        }

        private void FixedUpdate()
        {
            if (bribe.state == General_interactions.Bribe.bribe_state.Attacking)
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
