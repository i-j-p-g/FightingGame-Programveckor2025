using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player_damage : MonoBehaviour
{
    Rigidbody2D RigidPunch;
    public Transform Playercheck;
    public LayerMask Playermask;
    public PLayer1health player;

    bool hasAttackedOnce = false;
    bool hasAttackedTwice = false;
    bool hasKickedOnce = false;
    bool hasKickedTwice = false;

    float Cooldown;

    // Start is called before the first frame update
    void Start()
    {
        RigidPunch = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        Cooldown += Time.deltaTime;

        RaycastHit2D hit = Physics2D.Raycast(Playercheck.position, new Vector2(0, -1), 0.3f, Playermask);

        print(hit);
        if (Input.GetKeyDown(KeyCode.Z))
        {
            hasAttackedOnce = true;
            if (hit == true)
            {
                print("Z");
                PLayer1health.Playerhealth -= 15;


            }
            GetComponent<Animator>().Play("PUNch_Enemy1");
            Cooldown = 0;
        }
        

        if (Cooldown < 1)
        {



            if (Input.GetKeyDown(KeyCode.Z) && hasAttackedOnce == true)
            {
                hasAttackedTwice = true;
                if (hit == true)
                {


                    PLayer1health.Playerhealth -= 15;

                }
                GetComponent<Animator>().SetBool("PUNch2", true);
                hasAttackedOnce = false;
            }
            
        }
        else
        {
            hasAttackedOnce = false;
        }

        if (Cooldown < 2)
        {



            if (Input.GetKeyDown(KeyCode.Z) && hasAttackedTwice)
            {

                if (hit == true)
                {


                    PLayer1health.Playerhealth -= 20;

                }
                GetComponent<Animator>().Play("PUNch3");
                hasAttackedTwice = false;
            }

        }
        else
        {
            hasAttackedTwice = false;
        }

        


            if (Input.GetKeyDown(KeyCode.X))
            {
                hasKickedOnce = true;
                if (hit == true)
                {


                PLayer1health.Playerhealth -= 10;

                }
                GetComponent<Animator>().Play("KIck_1");
                Cooldown = 0;
            }
        
       

        if (Cooldown < 1)
        {




            if (Input.GetKeyDown(KeyCode.X) && hasKickedOnce == true)
            {
                hasKickedTwice = true;
                if (hit == true)
                {


                    PLayer1health.Playerhealth -= 13;

                }
                GetComponent<Animator>().Play("KIck_2");
                hasKickedOnce = false;
            }

        }
        else
        {
            hasKickedOnce = false;
        }

        if (Cooldown < 2)
        {



            if (Input.GetKeyDown(KeyCode.X) && hasKickedTwice)
            {

                if (hit == true)
                {


                    PLayer1health.Playerhealth -= 20;

                }
                GetComponent<Animator>().Play("Kick_3");
                hasKickedTwice = false;
            }
        }
        else
        {
            hasKickedTwice = false;
        }
        


        if (Input.GetKeyDown(KeyCode.C))
        {
            print("C");
            //Här lägger du in block koden när den e färdig//
        }
    }
}
