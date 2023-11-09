using System;
using Guards.Roaming;
using UnityEngine;

namespace Guards.General_interactions
{
    public class Bribe : MonoBehaviour
    {
        [SerializeField] private float bribeTimer;
        [SerializeField] private float gracePeriod;
        [SerializeField] private float bribeCooldown;
        [SerializeField] private float bribeCooldownTimer;
        public bribe_state state;
        public guard_type type;
        public KeyCode bribe = KeyCode.E;
        private GuardFOV guardFOV;

        public enum bribe_state
        {
            Waiting,
            Bribed,
            Attacking
        }

        public enum guard_type
        {
            Roaming,
            Regular,
            Key_Holder
        }

        private void Awake()
        {
            state = bribe_state.Waiting;
            bribeTimer = gracePeriod;
            bribeCooldownTimer = bribeCooldown;
            guardFOV = GetComponent<GuardFOV>();
        }

        private void FixedUpdate()
        {
            TakeAction();
        }

        public void GracePeriodCheck()
        {
            if (state == bribe_state.Waiting)
            {
                bribeTimer -= Time.deltaTime;
                if (bribeTimer > 0 && Input.GetKey(bribe))
                {
                    state = bribe_state.Bribed;
                    bribeCooldownTimer = bribeCooldown;
                }
                else if (bribeTimer <= 0)
                {
                    state = bribe_state.Attacking;
                    bribeCooldownTimer = bribeCooldown;
                }
            }
        }

        public void BribeReset()
        {
            bribeCooldownTimer -= Time.deltaTime;
            if (bribeCooldownTimer <= 0)
            {
                state = bribe_state.Waiting;
            }
        }

        public void TakeAction()
        {
            if (guardFOV.canSeePlayer)
            {
                GracePeriodCheck();
            }
            else if(state != bribe_state.Waiting)
            {
                BribeReset();
            }
        }
    }
}
