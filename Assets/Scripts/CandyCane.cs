using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyCane : WeaponAttacks
{
    [SerializeField] GameObject leftAttack;
    [SerializeField] GameObject rightAttack;

    PlayerMovement playerMove;
    [SerializeField] Vector2 attackSize = new Vector2(4f, 2f);

    private void Awake()
    {
        playerMove= GetComponentInParent<PlayerMovement>();
    }
    private void DealDamage(Collider2D[] collision)
    {
        for(int i= 0; i < collision.Length; i++)
        {
            Enemy e = collision[i].GetComponent<Enemy>();
            if (e != null)
            {
                collision[i].GetComponent<Enemy>().TakeDamage(weaponStats.damage);
            }
        }
    }

    public override void Attack()
    {
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
}
