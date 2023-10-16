using UnityEngine;

namespace Player.Camera
{
    public class MoveCamera : MonoBehaviour
    {
        public Transform cameraPosition;

        private void Update()
        {
            transform.position = cameraPosition.transform.position;
        }
    }
}