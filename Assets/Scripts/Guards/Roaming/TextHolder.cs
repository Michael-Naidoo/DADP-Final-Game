using System;
using UnityEngine;
using UnityEngine.UI;

namespace Guards.Roaming
{
    public class TextHolder : MonoBehaviour
    {
        public string speech;

        [SerializeField] private string attacking;
        [SerializeField] private string bribed;
        [SerializeField] private string waiting;

        private General_interactions.Bribe bribe;

        private void Start()
        {
            bribe = GetComponent<General_interactions.Bribe>();
        }

        private void Update()
        {
            if (bribe.state == General_interactions.Bribe.bribe_state.Attacking)
            {
                speech = attacking;
            }
            else if (bribe.state == General_interactions.Bribe.bribe_state.Bribed)
            {
                speech = bribed;
            }
            else
            {
                speech = waiting;
            }
        }
    }
}