using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Attack : MonoBehaviour
{
    public GameObject player;
    public float speed;
    public float attackRange = 2f;     //attack range
    public LayerMask playerMask;
    public Transform Enemycheck;       //position för raycasten
    public LayerMask EnemyMask;
    public float attackCooldown = 2f;  //tid mellan attacker

    private Animator animator;
    private bool canAttack = true;        // Attack timer
    private float distance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);

        if (distance <= attackRange && canAttack)
        {
            Attack();
        }
        else
        {
            
        }

        void Attack()
        {
            canAttack = false; //sätter attack cooldown

        }

    }
}
