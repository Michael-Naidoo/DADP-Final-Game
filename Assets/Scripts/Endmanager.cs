using System;
using System.Collections;
using System.Collections.Generic;
using Player.Interactions;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Endmanager : MonoBehaviour
{
    private GameObject player;
    private GameObject mother;
    public GameObject win;
    public GameObject lose;
    private PlayerInfo pI;
    private HealthBar hB;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        mother = GameObject.FindGameObjectWithTag("Mother");
        pI = player.GetComponent<PlayerInfo>();
        hB = mother.GetComponent<HealthBar>();
        
    }

    private void Update()
    {
        if (Win() == 0)
        {
            lose.SetActive(true);
        }
        else if (Win() == 1)
        {
            win.SetActive(true);
        }
    }

    int Win()
    {
        if (pI.hp <= 0 || hB.currentTime <= 0)

            return 0;

        else if (pI.keyRef == (pI.keys.Length - 1))
            
            return 1;

        return 2;
    }
}
