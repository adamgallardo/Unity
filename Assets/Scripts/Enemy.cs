using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Transform attackPosition;
    GameObject targetGameObject;
    [SerializeField] float speed;

    Rigidbody2D rigid;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    //Calculamos la dirección hacia donde se tiene que mover el monstruo para atacar al jugador
    private void FixedUpdate()
    {
        Vector3 direction = (attackPosition.position - transform.position).normalized;
        rigid.velocity = direction * speed;
    }

    //Función que llamamos cuando entra en contacto con el jugador
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject == targetGameObject)
        {
            Damage();
        }
    }

    //Función que llamamos cuando hace daño al jugador
    private void Damage()
    {
        Debug.Log("2dmg dealt");
    }

    //Función que llamamos cuando se crea un monstruo nuevo para darlo como objetivo al jugador
    public void SetTarget(GameObject target)
    {
        targetGameObject= target;
        attackPosition = target.transform;
    }
}
