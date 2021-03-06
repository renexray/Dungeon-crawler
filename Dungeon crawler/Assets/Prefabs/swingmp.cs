﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swingmp : MonoBehaviour
{

    private float timeBtwAttack;
    public float startTimeBtwAttack;

    public Transform attackPos;
    public LayerMask whatIsEnemies;
    public float attackRange;
    public int damage;
    public Animator playeranim;
    void Start()
    {
        playeranim = GetComponent<Animator>();
     }
    void Update()
    {
        if (timeBtwAttack <= 0)
        {
            // then you can attack
            if (Input.GetMouseButtonDown(0))
            {
                playeranim.SetTrigger("Knight");
                //playeranim.SetTrigger("Knight");
                Collider2D[] enemiesToDamge = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies);
                for (int i = 0; i < enemiesToDamge.Length; i++)
                {
                    enemiesToDamge[i].GetComponent<EnemyDeath>().DealDamage(damage);
                }

                timeBtwAttack = startTimeBtwAttack;
            }
            else
            {
                timeBtwAttack -= Time.deltaTime;
                {

                }
            }
        }
    }

        void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(attackPos.position, attackRange);
        }
}
