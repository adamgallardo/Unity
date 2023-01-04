using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rigid;
    [HideInInspector] public Vector3 movementVector;
    [HideInInspector] public float lastHorizontal;
    [HideInInspector] public float lastVertical;

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

        if(movementVector.x != 0)
        {
            lastHorizontal= movementVector.x;
        }
        if(movementVector.y != 0)
        {
            lastVertical= movementVector.y;
        }

        movementVector *= speed;

        rigid.velocity = movementVector;
    }
}
