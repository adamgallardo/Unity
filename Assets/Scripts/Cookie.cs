using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cookie : MonoBehaviour
{
    [SerializeField] int healthAmount;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerStats p = collision.GetComponent<PlayerStats>();
        if (p != null)
        {
            p.Heal(healthAmount);
            Destroy(gameObject);
        }
    }
}
