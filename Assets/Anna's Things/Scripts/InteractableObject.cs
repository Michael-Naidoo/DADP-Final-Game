using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public bool playerInRange;
    public string ItemName;
    public float interactionRange = 3f;
    public KeyCollector keyCollector;

    public string GetItemName(Transform player)
    {
        if (playerInRange && Vector3.Distance(transform.position, player.position) <= interactionRange)
        {
            return ItemName;
        }
        else
        {
            return " What is that ? "; // change it to whatever you like guys , or yall can leave it empty like "";  
        }
    }



    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0) && playerInRange)
        {

            gameObject.SetActive(false); // Deactivate the key.
            keyCollector.CollectKey();

        }






    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player entered the trigger zone of " + gameObject.name);
            playerInRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player exited the trigger zone of " + gameObject.name);
            playerInRange = false;
        }
    }
}
