using UnityEngine;
using UnityEngine.UI;

public class Bribe : MonoBehaviour
{
    public int playerDrugs = 0; // Assuming starting currency is 0
    public int requiredCurrency = 2; // Amount of drugs needed

    public Text currencyText; // Reference to the UI text element

   
    public void CheckAndDeductCurrency()
    {
        if (playerDrugs >= requiredCurrency)
        {
            // Player has enough drugs
            playerDrugs -= requiredCurrency;
            UpdateCurrencyText();
        }
        else
        {
            Debug.Log("Insufficient currency!"); 
            
        }
    }

  
    void UpdateCurrencyText()
    {
        if (currencyText != null)
        {
            currencyText.text = "Currency: " + playerDrugs.ToString(); // Display updated currency in the UI text
            currencyText.gameObject.SetActive(true); // Enable the UI riddle for the player to solve
        }
        else
        {
            Debug.Log("UI text reference not set!");
        }
    }
}