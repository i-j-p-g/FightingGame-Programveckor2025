using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Enemy_health : MonoBehaviour
{
    public Slider healthBar; // Reference to the UI Slider for the enemy's health bar
    public static int Enemyhealth = 1000;
    private int maxHealth = 1000; // Maximum health of the enemy

    void Start()
    {
        // Initialize the health bar
        if (healthBar != null)
        {
            healthBar.maxValue = maxHealth;
            healthBar.value = Enemyhealth;
        }
    }

    void Update()
    {
        print(Enemyhealth);

        // Update the health bar value
        if (healthBar != null)
        {
            healthBar.value = Enemyhealth;
        }

        // If enemy's health reaches zero, load the next scene
        if (Enemyhealth <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
