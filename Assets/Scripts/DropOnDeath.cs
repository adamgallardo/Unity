using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropOnDeath : MonoBehaviour
{
    [SerializeField] GameObject cookie;
    [SerializeField] [Range(0f, 1f)] float chance = 1f;

    public void CheckDrop()
    {
        if (Random.value < chance)
        {
            Transform t = Instantiate(cookie).transform;
            t.position = transform.position;
        }
    }
}
