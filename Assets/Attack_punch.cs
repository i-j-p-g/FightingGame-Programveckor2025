using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using UnityEngine;

public class Attack_punch : MonoBehaviour
{
    Rigidbody2D RigidPunch;
    public Transform Enemycheck;
    public LayerMask Enemymask;
    public Enemy_health enemy;

    public bool hasAttackedOnce = false;
    public bool hasAttackedTwice = false;
    bool hasKickedOnce = false;
    bool hasKickedTwice = false;

    float Cooldown;
    float ComboTimer;

    // Start is called before the first frame update
    void Start()
    {
        RigidPunch = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Cooldown += Time.deltaTime;
        ComboTimer += Time.deltaTime;

        RaycastHit2D hit = Physics2D.Raycast(Enemycheck.position, new Vector2(0, -1), 0.3f, Enemymask);

        print(hit);
        if (Input.GetKeyDown(KeyCode.J) && hasAttackedOnce == false && hasAttackedTwice == false)
        {

            hasAttackedOnce = true;
            if(hit == true)
            {
                
                Enemy_health.Enemyhealth -= 10;

                
            }
            GetComponent<Animator>().SetBool("Attack", true);
            Cooldown = 0;
        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            GetComponent<Animator>().SetBool("Attack", false);
        }
        


        if (Cooldown < 1)
        {



            if (Input.GetKeyDown(KeyCode.J) && hasAttackedOnce == true)
            {
                hasAttackedTwice = true;
                hasAttackedOnce = false;
                if (hit == true)
                {


                    Enemy_health.Enemyhealth -= 15;

                }
                GetComponent<Animator>().SetBool("Punch2", true);


            }
            if (Input.GetKeyUp(KeyCode.J))
            {
                GetComponent<Animator>().SetBool("Punch2", false);
            }


        }
        else
        {
            hasAttackedOnce = false;

        }

        if (Cooldown < 2 )
        {

            if (Input.GetKeyDown(KeyCode.J) && hasAttackedTwice == true)
            {

                
                if (hit == true)
                {


                    Enemy_health.Enemyhealth -= 30;

                }
                GetComponent<Animator>().SetBool("Punch3", true);
                hasAttackedTwice = false;
            }
            if (Input.GetKeyUp(KeyCode.J))
            {
                GetComponent<Animator>().SetBool("Punch3", false);
            }

        }
        else
        {
            hasAttackedTwice = false;
        }



        if (Input.GetKeyDown(KeyCode.K) && hasKickedOnce == false && hasKickedTwice == false)
        {
            hasKickedOnce = true;
            
            if (hit == true)
            {
                
                Enemy_health.Enemyhealth -= 15;


            }
            GetComponent<Animator>().SetBool("Attack2", true);
            Cooldown = 0;
        }
        if (Input.GetKeyUp(KeyCode.K))
        {
            GetComponent<Animator>().SetBool("Attack", false);
        }

        if (Cooldown < 1)
        {



            if (Input.GetKeyDown(KeyCode.K) && hasKickedOnce == true)
            {
                hasKickedTwice = true;
                
                if (hit == true)
                {


                    Enemy_health.Enemyhealth -= 20;

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

            if (Input.GetKeyDown(KeyCode.K) && hasKickedTwice == true)
            {

                
                if (hit == true)
                {


                    Enemy_health.Enemyhealth -= 30;

                }
                GetComponent<Animator>().Play("Kick_3");
                hasKickedTwice = false;
            }

        }
        else
        {
            hasKickedTwice = false;
        }



        if (Input.GetKeyDown(KeyCode.L))
        {
            print("L");
            //Här lägger du in block koden när den e färdig//
        }

        if (Input.GetKey(KeyCode.E))
        {
            GetComponent<Animator>().SetBool("Emote", true);
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            GetComponent<Animator>().SetBool("Emote", false);
        }

        
    }
}
