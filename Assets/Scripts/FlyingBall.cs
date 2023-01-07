using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyingBall : MonoBehaviour
{
    Vector3 direction;
    [SerializeField] float speed;
    [SerializeField] int damage = 1;
    public void SetDirection(float dir_x, float dir_y)
    {
        direction = new Vector3(dir_x, dir_y);
    }

    void Update()
    {
        transform.position += direction * speed*Time.deltaTime;

        Collider2D[] hit =Physics2D.OverlapCircleAll(transform.position, 0.3f);

        foreach (Collider2D c in hit)
        {
            Enemy enemy = c.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
                Destroy(gameObject);
                break;
            }
        }
    }
}
