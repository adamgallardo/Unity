using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerStats : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth = 100;
    [SerializeField] HealthBar hpBar;
    private bool isDead=false;
    float totaltime;

    private void Start()
    {
        hpBar.SetState(currentHealth, maxHealth);
    }

    private void Update()
    {
        totaltime += Time.deltaTime;
    }

    public void TakeDamage(int damage)
    {
        if (isDead == true) { return; }
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            GetComponent<PlayerGameOver>().GameOver(totaltime);
            isDead = true;
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
        hpBar.SetState(currentHealth, maxHealth);
    }
}
