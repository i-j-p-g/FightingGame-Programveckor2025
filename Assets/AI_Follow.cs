using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class AI_Follow : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public float followDuration = 2f;
    public float backAwayDuration = 4f;
    public Vector2 retreatPosition;
    public float followSpeed = 2f;      // Hastighet när fienden följer spelaren
    public float backAwaySpeed = 1f;    // Hastighet när fienden backar

    private float timer;
    private bool isBackingAway = false;
    private float distance;

    void Start()
    {
        timer = followDuration;  // Börjar med att följa spelaren
    }

    
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        timer -= Time.deltaTime;

        if (isBackingAway)
        {
            // Fienden rör sig mot en specifik retreat-position
            transform.position = Vector2.MoveTowards(transform.position, retreatPosition, speed * Time.deltaTime);

            // Om fienden når retreat-positionen eller tiden är slut, börja följa igen
            if (Vector2.Distance(transform.position, retreatPosition) < 0.1f || timer <= 0)
            {
                isBackingAway = false;
                timer = followDuration;  // Återställ timer för att följa igen
            }
        }
        else
        {
            // Fienden följer spelaren om avståndet är mindre än 14
            if (distance < 25)
            {
                transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
            }

            // När timern tar slut, börja backa
            if (timer <= 0)
            {
                isBackingAway = true;
                timer = backAwayDuration;  // Återställ timer för att backa
            }
        }

        

    }
}
