using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ChristmasBall : WeaponAttacks
{
    [SerializeField] GameObject ball;

    PlayerMovement playerMove;

    private void Awake()
    {
        playerMove = GetComponentInParent<PlayerMovement>();
    }
    public override void Attack()
    {
        GameObject thrownBall = Instantiate(ball);
        thrownBall.transform.position = transform.position;
        FlyingBall flyingBall = thrownBall.GetComponent<FlyingBall>();
        thrownBall.GetComponent<FlyingBall>().SetDirection(playerMove.lastHorizontal, 0f);
        flyingBall.damage = weaponStats.damage;
    }
}
