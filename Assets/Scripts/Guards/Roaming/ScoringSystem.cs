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

            scoreText.GetComponent<TMPro.TextMeshProUGUI>().text = "Drugs: " + theScore;
        }
        else
        {
            Debug.LogWarning("scoreText GameObject is not assigned.");
        }

        Destroy(gameObject);
    }
}





