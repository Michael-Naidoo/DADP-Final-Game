using System;
using System.Collections;
using System.Collections.Generic;
using Player.Interactions;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour
{
    public Slider slider;
    public PlayerInfo pI;

    private void Start()
    {
        SetMaxHealth();
    }

    private void Update()
    {
        SetHealth();
    }

    public void SetMaxHealth()
    {
        slider.maxValue = pI.maxHP;
        slider.value = pI.hp;
    }

    public void SetHealth()
    {
        slider.value = pI.hp;
    }



}
