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
        [SerializeField] private GameObject[] targetPos;
        private int targetIndex;
        private void Start()
        {
            navMesh = GetComponent<NavMeshAgent>();
            guardFOV = GetComponent<GuardFOV>();
            bribe = GetComponent<General_interactions.Bribe>();
            targetIndex = 0;
        }

        private void FixedUpdate()
        {
            if (bribe.state == General_interactions.Bribe.bribe_state.Attacking)
            {
                navMesh.SetDestination(guardFOV.player.transform.position);
            }
            else
            {
                navMesh.SetDestination(targetPos[targetIndex].transform.position);
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Target"))
            {
                if (targetIndex < targetPos.Length)
                {
                    targetIndex++;
                }
                else
                {
                    targetIndex = 0;
                }
            }
        }
    }
}
