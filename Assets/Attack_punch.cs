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


        RaycastHit2D hit = Physics2D.Raycast(Enemycheck.position, new Vector2(0, -1), 0.3f, Enemymask);

        print(hit);
        if (Input.GetKeyDown(KeyCode.J))
        {
            hasAttackedOnce = true;
            if(hit == true)
            {
                print("J");
                Enemy_health.Enemyhealth -= 10;
                

            }
            GetComponent<Animator>().SetBool("Attack", true);
        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            GetComponent<Animator>().SetBool("Attack", false);
           
            
        }

      
            if (Input.GetKeyDown(KeyCode.J) && hasAttackedOnce)
            {
            hasAttackedTwice = true;
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
        
        if (Input.GetKeyDown(KeyCode.J) && hasAttackedTwice)
        {
            if (hit == true)
            {


                Enemy_health.Enemyhealth -= 30;

            }
            GetComponent<Animator>().SetBool("Punch3", true);
        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            GetComponent<Animator>().SetBool("Punch3", false);
        }


        if (Input.GetKey(KeyCode.K))
        {
            hasKickedOnce = true;
            if(hit == true)
            {
                print("K");
                Enemy_health.Enemyhealth -= 10;
            }
            GetComponent<Animator>().SetBool("Attack2", true);
        }
        if (Input.GetKeyUp(KeyCode.K))
        {
            GetComponent<Animator>().SetBool("Attack2", false);
        }
        
        if (Input.GetKey(KeyCode.K) && hasKickedOnce)
        {
            hasKickedTwice = true;
            if (hit == true)
            {


                Enemy_health.Enemyhealth -= 13;

            }
            GetComponent<Animator>().SetBool("Kick2", true);
        }
        
        if (Input.GetKeyUp(KeyCode.K))
        {
            GetComponent<Animator>().SetBool("Kick2", false);

        }

        if (Input.GetKey(KeyCode.K) && hasKickedTwice)
        {
            if (hit == true)
            {


                Enemy_health.Enemyhealth -= 15;

            }
            GetComponent<Animator>().SetBool("Kick3", true);
        }


        if (Input.GetKeyUp(KeyCode.K))
        {
            GetComponent<Animator>().SetBool("Kick3", false);
        }



        if (Input.GetKeyDown(KeyCode.L))
        {
            print("L");
            //Här lägger du in block koden när den e färdig//
        }

        hasAttackedOnce = false;
        hasAttackedTwice = false;
        hasKickedOnce = false;
        hasKickedTwice = false;
    }
}
