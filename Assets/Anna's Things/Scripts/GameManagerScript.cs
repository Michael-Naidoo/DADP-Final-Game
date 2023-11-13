using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{



    public GameObject ruleMenu;
    public GameObject mainMenu;
    public GameObject canvas;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && canvas.activeSelf)
        {
            startWithGame();
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && !canvas.activeSelf)
        {
            canvas.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        if (Input.GetKeyDown(KeyCode.R) && ruleMenu.activeSelf)
        {
            closeRule();
        }  
        else if (Input.GetKeyDown(KeyCode.R) && mainMenu.activeSelf) 
        { 
            Rule();
            Debug.Log("not the problem");
        }   
        if (Input.GetKeyDown(KeyCode.Backspace) && mainMenu.activeSelf)
        {
            quit();
        }
    }


    public void startWithGame()
    {
        canvas.SetActive(false);                 
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;                   
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



