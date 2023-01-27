using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] GameObject enemy1;

    [SerializeField] float spawnerTimer;

    float timer;
    public float totaltime;
    [SerializeField] Vector2 spawnArea;
    [SerializeField] GameObject player;
    [SerializeField] GameObject enemy2;
    [SerializeField] float timerForEnemy2;

    //Cuando el timer se agota se llama a la función SpawnEnemy y se reinicia el timer
    void Update()
    {
        totaltime += Time.deltaTime;
        timer -= Time.deltaTime;
        if (timer < 0f)
        {
            SpawnEnemy();
            timer = spawnerTimer;
        }
    }

    //Función para que aparezcan enemigos
    private void SpawnEnemy()
    {
        Vector3 position = RandomPosition();

        position += player.transform.position;

        GameObject newEnemy = Instantiate(enemy1);
        newEnemy.transform.position = position;
        newEnemy.GetComponent<Enemy>().SetTarget(player);
        if (timerForEnemy2 < totaltime)
        {
            position = RandomPosition();
            position += player.transform.position;
            GameObject newDiffEnemy = Instantiate(enemy2);
            newDiffEnemy.transform.position = position;
            newDiffEnemy.GetComponent<Enemy>().SetTarget(player);
        }
    }

    //Función para determinar la posición donde apareceran los enemigos de forma aleatoria y siempre fuera de la pantalla
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
