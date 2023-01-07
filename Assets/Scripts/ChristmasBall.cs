using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ChristmasBall : MonoBehaviour
{
    [SerializeField] float cooldown;
    float timer;

    [SerializeField] GameObject ball;

    PlayerMovement playerMove;

    private void Awake()
    {
        playerMove = GetComponentInParent<PlayerMovement>();
    }

    private void Update()
    {
        if (timer < cooldown)
        {
            timer += Time.deltaTime;
            return;
        }

        timer = 0;
        ThrowBall();
    }

    private void ThrowBall()
    {
        GameObject thrownBall = Instantiate(ball);
        thrownBall.transform.position = transform.position;
        thrownBall.GetComponent<FlyingBall>().SetDirection(playerMove.lastHorizontal, 0f);
    }
}
