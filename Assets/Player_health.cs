using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1_health : MonoBehaviour
{
    public Slider healthBar; // Reference to the UI Slider for the player's health bar
    public static int PlayerHealth = 1000;
    private int maxHealth = 1000; // Maximum health of the player

    void Start()
    {
        // Initialize the health bar
        if (healthBar != null)
        {
            healthBar.maxValue = maxHealth;
            healthBar.value = PlayerHealth;
        }
    }

    void Update()
    {
        print(PlayerHealth);

        // Update the health bar value
        if (healthBar != null)
        {
            healthBar.value = PlayerHealth;
        }

        // Additional logic for player's health (e.g., respawn or game over) can be added here
        if (PlayerHealth <= 0)
        {
            Debug.Log("Player is dead!");
        }
    }
}
