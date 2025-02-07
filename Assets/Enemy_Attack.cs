using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Attack : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public float attackRange = 10f;     //attack range
    public LayerMask playerMask;
    public Transform Enemycheck;       //position för raycasten
    public LayerMask EnemyMask;
    public float attackCooldown = 2f;  //tid mellan attacker
    private float lastAttack;
    public int dammages = 3;

    public Animator animator;
    bool hasKickedOnce = true;
    bool hasKickedTwice = false;        
    private float distance;
    string[] attacks = new string[] { "PUNch" , "PUNch2" , "PUNch3" };

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Debug.Log("Distance: " + distance);
        Debug.Log("AttackRange: " + attackRange);
        if (distance <= attackRange && hasKickedOnce && (lastAttack + attackCooldown) <= Time.time)
        {
            Attack();
            lastAttack = Time.time;
        }
        else
        {
            FollowPlayer();  //Följ spelaren om hen är långt bort
        }

        void Attack()
        {
            // hasKickedOnce = false; // attack cooldown



            // Raycast för att känna av träff
            RaycastHit2D hit = Physics2D.Raycast(Enemycheck.position, Vector2.left * transform.localScale.x, 0.3f, playerMask);

            if (hit)
            {
                System.Random random = new System.Random();
                int useAttacks = random.Next(attacks.Length);
                string picAttack = attacks[useAttacks];

                Debug.Log("Enemy Kicked");
                PLayer1health.Playerhealth -= dammages;
                animator.SetBool(picAttack, true); // Sätter boolen "Enemy kick" till true för att starta animationen
                animator.Play(picAttack);
            }

            if (animator.GetBool("PUNch"))
            {
                animator.SetBool("PUNch", false);
            }
            if (animator.GetBool("PUNch2"))
            {
                animator.SetBool("PUNch2", false);
            }
            if (animator.GetBool("PUNch3"))
            {
                animator.SetBool("PUNch3", false);
            }

        }

        void FollowPlayer()
        {
            // följarfunktion om spelaren är långt bort
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime); 
        }



    }
}
