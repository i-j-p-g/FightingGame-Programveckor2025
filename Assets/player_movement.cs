using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    Rigidbody2D rb;
    public Transform groundcheck;
    public LayerMask Groundmask;
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

       
        RaycastHit2D hit = Physics2D.Raycast(groundcheck.position, new Vector2(0, -1), 0.3f, Groundmask);

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
            if(hit == true)
            {
                Yspeed = 50;
            }
                
        } 

        rb.velocity = new Vector2(Xspeed, Yspeed);
    }
}
