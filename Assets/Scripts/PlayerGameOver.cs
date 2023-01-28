using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGameOver : MonoBehaviour
{
    public GameObject gameOverPanel;
    [SerializeField] TMPro.TextMeshProUGUI lvl;
    [SerializeField] TMPro.TextMeshProUGUI lvlGameOver;
    [SerializeField] TMPro.TextMeshProUGUI time;
    [SerializeField] GameObject weapons;
    [SerializeField] GameObject enemySpawner;


    public void GameOver(float totaltime)
    {
        Debug.Log("Game Over");
        GetComponent<PlayerMovement>().enabled= false;
        weapons.SetActive(false);
        enemySpawner.SetActive(false);
        gameOverPanel.SetActive(true);
        lvlGameOver.text = lvl.text;
        time.text = "Tiempo: " + totaltime;
    }
}
