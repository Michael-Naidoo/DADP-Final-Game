using System;
using Guards.Roaming;
using UnityEngine;
using UnityEngine.UI;

namespace prototype_text
{
    public class DistanceCheck : MonoBehaviour
    {
        private GameObject guard;
        private GuardFOV _guardFOV;
        private TextHolder textHolder;
        [SerializeField] private float maxDist;
        [SerializeField] private GameObject textBox;
        [SerializeField] private Text text;

        private void Update()
        {
            FindGuard(maxDist);
            ShowText();
        }

        void FindGuard(float dist)
        {
            Collider[] allColliders = Physics.OverlapSphere(transform.position, dist);
            for (int i = 0; i < allColliders.Length; i++)
            {
                if (allColliders[i].CompareTag("Guard"))
                {
                    if (guard  == null)
                    {
                        guard = allColliders[i].gameObject;
                    }
                    else if (Vector3.Distance
                                 (transform.position, guard.transform.position)
                             > 
                             Vector3.Distance
                                 (transform.position, allColliders[i].transform.position))
                    {
                        guard = allColliders[i].gameObject;
                    }
                }
            }
        }

        void ShowText()
        {
            if (guard != null)
            {
                _guardFOV = guard.GetComponent<GuardFOV>();
                if (_guardFOV.canSeePlayer)
                {
                    textBox.SetActive(true);
                    textHolder = guard.GetComponent<TextHolder>();
                    text.text = textHolder.speech;
                }
                else
                {
                    textBox.SetActive(false);
                }
            }
        }
    }
}
