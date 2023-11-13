using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Player.Interactions
{
    public class Pickups : MonoBehaviour
    {
        private PlayerInfo pI;

        private void Start()
        {
            pI = GetComponent<PlayerInfo>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Drug"))
            {
                pI.drugs += Random.Range(1, 3);
                Destroy(other.gameObject);
            }
        }
    }
}
