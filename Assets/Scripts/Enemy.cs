using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] Transform attackPosition;
    GameObject targetGameObject;
    [SerializeField] float speed;

    Rigidbody2D rigid;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        targetGameObject = attackPosition.gameObject;
    }

    private void FixedUpdate()
    {
        Vector3 direction = (attackPosition.position - transform.position).normalized;
        rigid.velocity = direction * speed;
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject == targetGameObject)
        {
            Damage();
        }
    }

    private void Damage()
    {
        Debug.Log("2dmg dealt");
    }
}
