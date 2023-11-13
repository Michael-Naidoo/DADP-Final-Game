using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthBar;
    public float maxTime = 60.0f;  // Set the maximum time in seconds
    public float currentTime;
    public uimanager uiManager;

    void Start()
    {
        currentTime = maxTime;
        healthBar.maxValue = maxTime;
        healthBar.value = currentTime;
    }

    void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;  // Decrease the timer over time
            healthBar.value = currentTime;
        }
        else
        {
            // Timer has reached zero, handle this as needed (e.g., game over, reset, etc.)
            Debug.Log("Time's up!");
            uiManager.gameOver();
        }
    }
}
