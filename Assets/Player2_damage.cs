using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_damage : MonoBehaviour
{
    Rigidbody2D RigidPunch;
    public Transform Playercheck;
    public LayerMask Playermask;
    public Player1_health player;

    // Start is called before the first frame update
    void Start()
    {
        RigidPunch = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {


        RaycastHit2D hit = Physics2D.Raycast(Playercheck.position, new Vector2(0, -1), 0.3f, Playermask);

        print(hit);
        if (Input.GetKeyDown(KeyCode.Z))
        {

            if (hit == true)
            {
                print("Z");
                Player1_health.Playerhealth -= 15;


            }

        }
        if (Input.GetKeyDown(KeyCode.X))
        {

            if (hit == true)
            {
                print("X");
                Player1_health.Playerhealth -= 10;
            }

        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            print("C");
            //Här lägger du in block koden när den e färdig//
        }
    }
}
