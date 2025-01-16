using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public float maxHealth = 100f; // Maximum health of the player/enemy
    public float currentHealth;   // Current health of the player/enemy

    private void Start()
    {
        // Initialize current health to max health at the start
        currentHealth = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        // Decrease health but prevent it from going below 0
        currentHealth = Mathf.Clamp(currentHealth - damage, 0, maxHealth);
        Debug.Log("Health decreased! Current Health: " + currentHealth);
    }

    public void Heal(float amount)
    {
        // Increase health but prevent it from exceeding max health
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log("Health increased! Current Health: " + currentHealth);
    }

    public bool IsDead()
    {
        // Return true if health is 0 or less
        return currentHealth <= 0;
    }
}
