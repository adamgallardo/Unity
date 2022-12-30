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

    //Calculamos la direcci�n hacia donde se tiene que mover el monstruo para atacar al jugador
    private void FixedUpdate()
    {
        Vector3 direction = (attackPosition.position - transform.position).normalized;
        rigid.velocity = direction * speed;
    }

    //Funci�n que llamamos cuando entra en contacto con el jugador
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject == targetGameObject)
        {
            Damage();
        }
    }

    //Funci�n que llamamos cuando hace da�o al jugador
    private void Damage()
    {
        Debug.Log("2dmg dealt");
    }

    //Funci�n que llamamos cuando se crea un monstruo nuevo para darlo como objetivo al jugador
    public void SetTarget(GameObject target)
    {
        targetGameObject= target;
        attackPosition = target.transform;
    }
}
