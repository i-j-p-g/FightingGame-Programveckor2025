using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

using UnityEngine;

public class AI_Follow : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public float followDuration = 2f;
    public float backAwayDuration = 4f;
    public Vector2 retreatPosition;
    public float followSpeed = 2f;      // Hastighet n�r fienden f�ljer spelaren
    public float backAwaySpeed = 1f;    // Hastighet n�r fienden backar
    Rigidbody2D rb;

    private float timer;
    private bool isBackingAway = false;
    private float distance;
    bool IsWalking = false;

    void Start()
    {
        timer = followDuration;  // B�rjar med att f�lja spelaren
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
       if(rb.velocity.x == 0)
        {
            GetComponent<Animator>().SetBool("Move", false);
        }else if(rb.velocity.x <= 1)
        {
            GetComponent<Animator>().SetBool("Move", true);
        }
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        timer -= Time.deltaTime;
        
        if (isBackingAway)
        {
            // Fienden r�r sig mot en specifik retreat-position
            transform.position = Vector2.MoveTowards(transform.position, retreatPosition, speed * Time.deltaTime);

            IsWalking = true;

            // Om fienden n�r retreat-positionen eller tiden �r slut, b�rja f�lja igen
            if (Vector2.Distance(transform.position, retreatPosition) < 0.1f || timer <= 0)
            {
                isBackingAway = false;
                timer = followDuration;  // �terst�ll timer f�r att f�lja igen
            }
        }
        else
        {
            // Fienden f�ljer spelaren om avst�ndet �r mindre �n 40
            if (distance < 40)
            {
                IsWalking = true;
                transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
            }

            // N�r timern tar slut, b�rja backa
            if (timer <= 0)
            {
                IsWalking = true;
                isBackingAway = true;
                timer = backAwayDuration;  // �terst�ll timer f�r att backa
            }
        }
        
       
        

        

    }
}
