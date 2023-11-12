using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SelectionManager : MonoBehaviour
{
    public GameObject interaction_Info_UI;
    Text interaction_text;
    public Transform playerTransform; // Reference to the player's transform.

    private void Start()
    {
        interaction_text = interaction_Info_UI.GetComponent<Text>();
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            var selectionTransform = hit.transform;

            if (selectionTransform.GetComponent<InteractableObject>() && selectionTransform.GetComponent<InteractableObject>().playerInRange)
            {
                // Pass the player's transform to GetItemName method.
                interaction_text.text = selectionTransform.GetComponent<InteractableObject>().GetItemName(playerTransform);
                interaction_Info_UI.SetActive(true);
            }
            else
            {
                interaction_Info_UI.SetActive(false);
            }

        }
        else
        {
            interaction_Info_UI.SetActive(false);
        }
    }
}