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
    

    private float timer;
    private bool isBackingAway = false;
    private float distance;

    void Start()
    {
        timer = followDuration;  // B�rjar med att f�lja spelaren
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
            // Fienden backar bort fr�n spelaren
            if (distance < 14)
            {
                transform.position = Vector2.MoveTowards(transform.position, transform.position - (Vector3)direction, speed * Time.deltaTime);
            }

            // N�r timern n�r noll, b�rja f�lja igen
            if (timer <= 0)
            {
                isBackingAway = false;
                timer = followDuration;  // �terst�ll timer f�r att f�lja
            }
        }
        else

        if (distance < 14)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
            

        }

        if (timer <= 0)
        {
            isBackingAway = true;
            timer = backAwayDuration;  // �terst�ll timer f�r att backa
        }

    }
}
