using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth = 100;
    [SerializeField] HealthBar hpBar;

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Debug.Log("You died");
        }
        hpBar.SetState(currentHealth, maxHealth);
    }
    public void Heal (int amount)
    {
        if (currentHealth <= 0) { return; }
        currentHealth += amount;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }      
    }
}
