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
                Enemy_health.Enemyhealth -= 15;
                

            }
            GetComponent<Animator>().SetBool("Attack", true);
        }
        if (Input.GetKeyUp(KeyCode.J))
        {
            GetComponent<Animator>().SetBool("Attack", false);
           
            
        }

      
            if (Input.GetKeyDown(KeyCode.J) && hasAttackedOnce)
            {
            if (hit == true)
            {


                Enemy_health.Enemyhealth -= 15;
                
            }
            }
        GetComponent<Animator>().SetBool("Punch2", true);
        if (Input.GetKeyUp(KeyCode.J))
            {
                GetComponent<Animator>().SetBool("Punch2", false);
            hasAttackedTwice = true;
            }
        
        if (Input.GetKeyDown(KeyCode.J) && hasAttackedTwice)
        {
            if (hit == true)
            {


                Enemy_health.Enemyhealth -= 15;

            }
            GetComponent<Animator>().SetBool("Punch3", true);
        }
        
        if (Input.GetKeyUp(KeyCode.J))
        {
            GetComponent<Animator>().SetBool("Punch3", false);
        }


        if (Input.GetKeyDown(KeyCode.K))
        {

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
        if (Input.GetKeyDown(KeyCode.L))
        {
            print("L");
            //Här lägger du in block koden när den e färdig//
        }

        hasAttackedOnce = false;
        hasAttackedTwice = false;
    }
}
