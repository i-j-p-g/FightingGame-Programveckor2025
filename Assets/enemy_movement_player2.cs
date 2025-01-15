using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_movement_player2 : MonoBehaviour
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

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Xspeed = 15;
            GetComponent<Animator>().SetBool("MOve", true);
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            GetComponent<Animator>().SetBool("MOve", false);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Xspeed = -25;
            GetComponent<Animator>().SetBool("MOve", true);
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            GetComponent<Animator>().SetBool("MOve", false);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (hit == true)
            {
                Yspeed = 50;
            }
            GetComponent<Animator>().SetBool("JUmp", true);
        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            GetComponent<Animator>().SetBool("JUmp", false);
        }

        rb.velocity = new Vector2(Xspeed, Yspeed);
    }
}
