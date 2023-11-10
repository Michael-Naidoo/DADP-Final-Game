using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public GameObject scoreText;
    private int theScore;
    //public AudioSource collectSound;

    void OnTriggerEnter(Collider other)
    {
        if (scoreText != null)
        {
            //collectSound.Play();
            theScore++;
            /*Text textComponent = scoreText.GetComponent<Text>();

           
            if (textComponent != null)
            {
                textComponent.text = "Drugs: " + theScore;
            }
            else
            {
                Debug.LogWarning("Text component not found on the scoreText GameObject.");
            }*/

            scoreText.GetComponent<TMPro.TextMeshProUGUI>().text = "Drugs: " + theScore;
        }
        else
        {
            Debug.LogWarning("scoreText GameObject is not assigned.");
        }

        Destroy(gameObject);
    }
}





