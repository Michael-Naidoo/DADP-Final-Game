using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{



    public GameObject ruleMenu;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void startWithGame()
    {
        SceneManager.LoadScene("UI_Scene"); // change to whatever you like 
    }



    public void Rule()
    {
        ruleMenu.SetActive(true);
    }

    public void closeRule()
    {
        ruleMenu.SetActive(false);

    }

    public void quit()
    {
        Application.Quit();
    }



}



