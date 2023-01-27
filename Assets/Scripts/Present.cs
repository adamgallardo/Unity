using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Present : WeaponAttacks
{

    [SerializeField] GameObject present;
    [SerializeField] Vector2 spawnArea;
    [SerializeField] GameObject player;

    private Vector3 RandomPosition()
    {
        Vector3 position = new Vector3();

        float f = UnityEngine.Random.value > 0.5f ? -1f : 1f;
        if (UnityEngine.Random.value > 0.5f)
        {
            position.x = UnityEngine.Random.Range(-spawnArea.x, spawnArea.x);
            position.y = spawnArea.y * f;
        }
        else
        {
            position.y = UnityEngine.Random.Range(-spawnArea.y, spawnArea.y);
            position.x = spawnArea.x * f;

        }

        position.z = 0;

        return position;
    }

    public override void Attack()
    {
        Vector3 position = RandomPosition();
        position += player.transform.position;
        GameObject ThrownPresent = Instantiate(present);
        Explosion explosion = ThrownPresent.GetComponent<Explosion>();
        ThrownPresent.transform.position = position;
        explosion.damage = weaponStats.damage;
    }
}
