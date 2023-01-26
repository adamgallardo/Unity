using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] int damage;


    void Update()
    {
        Collider2D[] hit = Physics2D.OverlapCircleAll(transform.position, 0.3f);

        foreach (Collider2D c in hit)
        {
            Enemy enemy = c.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
                break;
            }
        }
    }
}
