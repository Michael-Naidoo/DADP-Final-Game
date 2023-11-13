using System;
using Guards.Roaming;
using Player.Interactions;
using UnityEngine;

namespace Guards.General_interactions
{
    public class Bribe : MonoBehaviour
    {
        [SerializeField] private float bribeTimer;
        [SerializeField] private int bribeCost;
        [SerializeField] private float gracePeriod;
        [SerializeField] private float bribeCooldown;
        [SerializeField] private float bribeCooldownTimer;
        public bribe_state state;
        public guard_type type;
        public KeyCode bribe = KeyCode.E;
        private GuardFOV guardFOV;
        private GameObject player;
        private PlayerInfo pI;

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
            player = GameObject.FindWithTag("Player");
            pI = player.GetComponent<PlayerInfo>();
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
                if (bribeTimer > 0 && Input.GetKey(bribe) && pI.drugs >= bribeCost)
                {
                    state = bribe_state.Bribed;
                    bribeCooldownTimer = bribeCooldown;
                    bribeTimer = gracePeriod;
                }
                else if (bribeTimer <= 0)
                {
                    state = bribe_state.Attacking;
                    bribeCooldownTimer = bribeCooldown;
                    bribeTimer = gracePeriod;
                }
            }
        }

        public void BribeReset()
        {
            if (state == bribe_state.Bribed)
            {
                bribeCooldownTimer -= Time.deltaTime;
                if (bribeCooldownTimer <= 0)
                {
                    state = bribe_state.Waiting;
                }
            }
            else
            {
                state = bribe_state.Waiting;
            }
        }

        public void TakeAction()
        {
            if (type == guard_type.Roaming)
            {
                if(state == bribe_state.Attacking && !guardFOV.canSeePlayer)
                {
                    BribeReset();
                }
                else if(state == bribe_state.Bribed)
                {
                    bribeTimer = gracePeriod;
                    BribeReset();
                }
                else  if (guardFOV.canSeePlayer)
                {
                    GracePeriodCheck();
                }
            }
            else
            {
                if (Input.GetKey(bribe) && pI.drugs >= bribeCost)
                {
                    state = bribe_state.Bribed;
                }
            }
        }
    }
}
