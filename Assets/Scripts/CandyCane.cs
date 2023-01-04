using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyCane : MonoBehaviour
{
    [SerializeField] float cooldown = 4f;
    float timer;

    [SerializeField] GameObject leftAttack;
    [SerializeField] GameObject rightAttack;

    PlayerMovement playerMove;
    [SerializeField] Vector2 attackSize = new Vector2(4f, 2f);
    [SerializeField] int damage = 1;

    private void Awake()
    {
        playerMove= GetComponentInParent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0f)
        {
            Attack();
        }
    }

    private void Attack()
    {
        timer = cooldown;

        if (playerMove.lastHorizontal > 0) 
        {
            rightAttack.SetActive(true);
            Collider2D[] collision = Physics2D.OverlapBoxAll(rightAttack.transform.position, attackSize, 0f);
            DealDamage(collision);
        }
        else
        {
            leftAttack.SetActive(true);
            Collider2D[] collision = Physics2D.OverlapBoxAll(leftAttack.transform.position, attackSize, 0f);
            DealDamage(collision);
        }
    }

    private void DealDamage(Collider2D[] collision)
    {
        for(int i= 0; i < collision.Length; i++)
        {
            Enemy e = collision[i].GetComponent<Enemy>();
            if (e != null)
            {
                collision[i].GetComponent<Enemy>().TakeDamage(damage);
            }
        }
    }
}
