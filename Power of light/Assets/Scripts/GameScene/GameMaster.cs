﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour {

    [SerializeField] float maxHealth;
    float health;
    public float Health {
        get
        {
            return health; 
        }
        set
        {
            health = value;
            UpdateHealthUI(); 
            if (health <= 0)
            {
                health = 0;
                BattleLost(); 
            }
        }
    }
    int gold; 
    int Gold
    {
        get
        {
            return gold;
        }
        set
        {
            gold = value;
            GoldText.UpdateText(gold); 
        }
    }

    public static GameMaster instance;

    private void Awake()
    {
        Gold = 0; 

        if (instance == null) instance = this;
        else this.enabled = false;

        health = maxHealth; 
    }

    private void UpdateHealthUI()
    {
       
    } 

    private void UpdateGoldUI()
    {

    }

    void DamageCity(float damage)
    {
        Health -= damage;
    }

    public void IncreaseGold(int amount)
    {
        Gold += amount; 
    }

    public void WaveEnded()
    {
        Health = maxHealth;
    }

    public void BattleLost()
    {
        //game over
    }
}