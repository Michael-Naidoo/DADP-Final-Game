using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Player.Interactions
{
    public class Pickups : MonoBehaviour
    {
        [SerializeField] private PlayerInfo pI;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Drug"))
            {
                var rand = Random.Range(1, 5);
                pI.drugs += rand;
                Debug.Log("+" + rand + " Drugs");
                Destroy(other.gameObject);
            }
        }
    }
}
