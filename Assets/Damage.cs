using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour

{
    public int maxHealth = 3; // Maximal h�lsa
    private int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth; // S�tter startv�rdet p� h�lsan
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
