using System;
using UnityEngine;

namespace Player.Interactions
{
    public class Pickups : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Drug"))
            {
                Debug.Log("+1 Drug");
                Destroy(other.gameObject);
            }
        }
    }
}
