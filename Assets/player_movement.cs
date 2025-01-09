using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float Xspeed = 0;
        float Yspeed = rb.velocity.y;


        if (Input.GetKey(KeyCode.D))
        {
            Xspeed = 25;
        }

        if (Input.GetKey(KeyCode.A))
        {
            Xspeed = -15;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            Yspeed = 50;
        }

        rb.velocity = new Vector2(Xspeed, Yspeed);
    }
}
