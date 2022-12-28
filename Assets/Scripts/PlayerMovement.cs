using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rigid;
    Vector3 movementVector;

    public Joystick joystick;

    [SerializeField] float speed = 3f;
    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        movementVector = new Vector3();
    }

    // Update is called once per frame
    void Update()
    {
        movementVector.x = joystick.Horizontal;
        movementVector.y = joystick.Vertical;

        movementVector *= speed;

        rigid.velocity = movementVector;
    }
}
