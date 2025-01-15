using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_damage : MonoBehaviour
{
    Rigidbody2D RigidPunch;
    public Transform Playercheck;
    public LayerMask Playermask;
    public Player1_health player;

    bool hasAttackedOnce = false;
    bool hasAttackedTwice = false;
    bool hasKickedOnce = false;
    bool hasKickedTwice = false;

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
            hasAttackedOnce = true;
            if (hit == true)
            {
                print("Z");
                Player1_health.Playerhealth -= 15;


            }
            GetComponent<Animator>().SetBool("PUNch", true);
        }
        if (Input.GetKeyUp(KeyCode.Z))
        {
            GetComponent<Animator>().SetBool("PUNch", false);
        }

        if(Input.GetKeyDown(KeyCode.Z) && hasAttackedOnce)
        {
            hasAttackedTwice = true;
            if (hit == true)
            {


                Player1_health.Playerhealth -= 15;

            }
            GetComponent<Animator>().SetBool("PUNch2", true);
        }
        if (Input.GetKeyUp(KeyCode.Z))
        {
            GetComponent<Animator>().SetBool("PUNch2", false);
        }

        if (Input.GetKeyDown(KeyCode.Z) && hasAttackedTwice)
        {
            
            if (hit == true)
            {


                Player1_health.Playerhealth -= 20;

            }
            GetComponent<Animator>().SetBool("PUNch3", true);
        }
        if (Input.GetKeyUp(KeyCode.Z))
        {
            GetComponent<Animator>().SetBool("PUNch3", false);
        }


        if (Input.GetKeyDown(KeyCode.X))
        {
            hasKickedOnce = true;
            if (hit == true)
            {


                Player1_health.Playerhealth -= 10;

            }
            GetComponent<Animator>().SetBool("KIck", true);
        }
        if (Input.GetKeyUp(KeyCode.X))
        {
            GetComponent<Animator>().SetBool("KIck", false);
        }

        if (Input.GetKeyDown(KeyCode.X) && hasKickedOnce)
        {
            hasKickedTwice = true;
            if (hit == true)
            {


                Player1_health.Playerhealth -= 13;

            }
            GetComponent<Animator>().SetBool("KIck2", true);
        }
        if (Input.GetKeyUp(KeyCode.X))
        {
            GetComponent<Animator>().SetBool("KIck2", false);
        }


        if (Input.GetKeyDown(KeyCode.X) && hasKickedTwice)
        {
            
            if (hit == true)
            {


                Player1_health.Playerhealth -= 20;

            }
            GetComponent<Animator>().SetBool("KIck3", true);
        }
        if (Input.GetKeyUp(KeyCode.X))
        {
            GetComponent<Animator>().SetBool("KIck3", false);
        }


        if (Input.GetKeyDown(KeyCode.C))
        {
            print("C");
            //Här lägger du in block koden när den e färdig//
        }
    }
}
