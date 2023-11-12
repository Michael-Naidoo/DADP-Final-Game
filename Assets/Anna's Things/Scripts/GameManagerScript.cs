using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public GameObject ruleMenu;
    public GameObject mainMenu;
    public GameObject panel;
    public KeyCode pause = KeyCode.Escape;

    private void Update()
    {
        if (Input.GetKeyDown(pause))        
        {                                   
            if (panel.activeSelf)                      
            {                               
               panel.SetActive(false);
               Debug.Log("active");
               Cursor.lockState = CursorLockMode.Locked;
               Cursor.visible = false;
            }                               
            else                            
            {      
                Debug.Log("inactive");  
                panel.SetActive(true);      
                mainMenu.SetActive(true);   
                ruleMenu.SetActive(false);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }
    }

    public void startWithGame()
    {
        panel.SetActive(false);
    }



    public void Rule()
    {
        ruleMenu.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void closeRule()
    {
        ruleMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void quit()
    {
        Application.Quit();
    }



}



