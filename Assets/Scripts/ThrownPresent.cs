using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ThrownPresent : MonoBehaviour
{
    [SerializeField] float timeToExplode;
    [SerializeField] GameObject explosion;
    float timer;
    // Update is called once per frame
    void Update()
    {
        if (timer < timeToExplode)
        {
            timer += Time.deltaTime;
            return;
        }

        timer = 0;
        Explode();
    }

    private void Explode()
    {
        GameObject thrownBall = Instantiate(explosion);
        thrownBall.transform.position = transform.position;
        Destroy(gameObject);
    }
}
