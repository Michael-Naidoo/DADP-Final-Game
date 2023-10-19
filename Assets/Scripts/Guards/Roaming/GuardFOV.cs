using System;
using System.Collections;
using UnityEngine;

namespace Guards.Roaming
{
    public class GuardFOV : MonoBehaviour
    {
        [Header("Constraints")]
        public float radius;
        [Range(0, 360)]
        public float angle;

        [Header("References")]
        public GameObject player;

        [Header("LayerMasks")]
        public LayerMask whatIsPlayer;
        public LayerMask whatIaObstruction;

        public bool canSeePlayer;

        private void Start()
        {
            player = GameObject.FindWithTag("Player");
            StartCoroutine(FOVRoutine());
        }

        private IEnumerator FOVRoutine()
        {
            WaitForSeconds wait = new WaitForSeconds(0.2f);
            
            while (true)
            {
                yield return wait;
                FieldOfViewCheck();
            }
        }

        private void FieldOfViewCheck()
        {
            Collider[] rangeChecks = Physics.OverlapSphere(transform.position, radius, whatIsPlayer);

            if (rangeChecks.Length != 0)
            {
                Transform target = rangeChecks[0].transform;
                Vector3 directionToTarget = (target.transform.position - transform.position).normalized;

                if (Vector3.Angle(transform.position, directionToTarget) < angle/2)
                {
                    float distanceToTarget = Vector3.Distance(transform.position, target.transform.position);

                    if (!Physics.Raycast(transform.position, directionToTarget, distanceToTarget, whatIaObstruction))
                    {
                        canSeePlayer = true;
                    }
                    else
                    {
                        canSeePlayer = false;
                    }
                }
                else
                {
                    canSeePlayer = false;
                }
            }
            else if (canSeePlayer)
            {
                canSeePlayer = false;
            }
        }
    }
}
