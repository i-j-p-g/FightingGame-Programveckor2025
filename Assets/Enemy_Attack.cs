using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Attack : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public float attackRange = 2f;     //attack range
    public LayerMask playerMask;
    public Transform Enemycheck;       //position f�r raycasten
    public LayerMask EnemyMask;
    public float attackCooldown = 2f;  //tid mellan attacker

    private Animator animator;
    bool hasKickedOnce = false;
    bool hasKickedTwice = false;        
    private float distance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);

        if (distance <= attackRange && hasKickedOnce)
        {
            Attack();
        }
        else
        {
            FollowPlayer();  //F�lj spelaren om hen �r l�ngt brot
        }

        void Attack()
        {
            hasKickedOnce = false; // attack cooldown
            
            animator.SetBool("Enemy Kick", true); // S�tter boolen "Enemy kick" till true f�r att starta animationen

            // Raycast f�r att k�nna av tr�ff
            RaycastHit2D hit = Physics2D.Raycast(Enemycheck.position, Vector2.right * transform.localScale.x, 0.3f, playerMask);

            
        }

        void FollowPlayer()
        {
            // f�ljarfunktion om spelaren �r l�ngt bort
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime); 
        }



    }
}
