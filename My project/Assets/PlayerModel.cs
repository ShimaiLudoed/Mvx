using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel
{
    public int CurHealth { get; private set; } 
    static event Action OnHealthChange;
    static event Action OnPlayerDead;

    public PlayerModel(int health)
    {
        CurHealth = health;
    }
    public void TakeDamage(int damage)
    {
        CurHealth-=damage;
        OnHealthChange?.Invoke();
        if(CurHealth<=0)
        {
            OnPlayerDead?.Invoke(); 
        }
    }
}
