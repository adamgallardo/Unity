using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Present : MonoBehaviour
{
    [SerializeField] float cooldown = 2;
    float timer;
    [SerializeField] GameObject present;
    [SerializeField] Vector2 spawnArea;
    [SerializeField] GameObject player;

    void Update()
    {
        if (timer < cooldown)
        {
            timer += Time.deltaTime;
            return;
        }

        timer = 0;
        ThrowPresent();
    }

    private void ThrowPresent()
    {
        Vector3 position = RandomPosition();
        position += player.transform.position;
        GameObject ThrownPresent = Instantiate(present);
        ThrownPresent.transform.position = position;
    }
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
}
