using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class WeaponStats
{
    public int damage;
    public float cooldown;

    public WeaponStats(int damage, float cooldown)
    {
        this.damage = damage;
        this.cooldown = cooldown;
    }
}
[CreateAssetMenu]
public class WeaponData : ScriptableObject
{
    public string Name;
    public WeaponStats stats;
    public GameObject weaponPrefab;
}
