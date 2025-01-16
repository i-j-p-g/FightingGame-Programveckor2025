using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskedHealthBar : MonoBehaviour
{
    [SerializeField] private RectTransform healthBar; // The health bar to move
    [SerializeField] private HealthManager healthManager; // Reference to the health system script
    private float maxHealth;

    private float initialPosition; // The starting position of the health bar

    private void Start()
    {
        maxHealth = healthManager.maxHealth;

        // Save the starting position of the health bar
        initialPosition = healthBar.localPosition.x;
    }

    private void Update()
    {
        float currentHealth = healthManager.currentHealth; // Get current health
        UpdateHealthBar(currentHealth);
    }

    private void UpdateHealthBar(float currentHealth)
    {
        float healthPercentage = Mathf.Clamp01(currentHealth / maxHealth);

        // Calculate the new position of the health bar based on health
        float newPosition = initialPosition - (1 - healthPercentage) * healthBar.rect.width;

        // Update the health bar's position
        healthBar.localPosition = new Vector3(newPosition, healthBar.localPosition.y, healthBar.localPosition.z);
    }
}
