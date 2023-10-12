using System;
using UnityEngine;

namespace Player.Movement
{
    public class PlayerMovement : MonoBehaviour
    {
        [Header("Components")]
        [SerializeField] private GameObject player;
        [SerializeField] private Rigidbody rb;

        [Header("Movement")]
        public float speed;

        [Header("Key binds")]
        [SerializeField] private KeyCode jump = KeyCode.Space;

        private void Start()
        {
            player = GameObject.FindWithTag("Player");
            rb = player.GetComponent<Rigidbody>();
        }

        private void Update()
        {
            MovePlayer();
        }

        private void MovePlayer()
        {
            var horizontalInput = Input.GetAxis("Horizontal");
            var verticalInput = Input.GetAxis("Vertical");

            var horizontalForce = horizontalInput * speed * Time.deltaTime * 100;
            var verticalForce = verticalInput * speed * Time.deltaTime * 100;
            var moveForce = new Vector3(horizontalForce, 0, verticalForce);
            
            rb.AddForce(moveForce, ForceMode.Force);

            if (moveForce == Vector3.zero)
            {
                rb.velocity = new Vector3(0, rb.velocity.y, 0);
            }

            if (rb.velocity.magnitude > speed)
            {
                rb.velocity = rb.velocity.normalized * speed;
            }
        }
    }
}
