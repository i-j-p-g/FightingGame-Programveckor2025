using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour

{
    public int maxHealth = 3; // Maximal hälsa
    private int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth; // Sätter startvärdet på hälsan
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
