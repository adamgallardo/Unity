using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class WeaponAttacks : MonoBehaviour
{
    public WeaponData weaponData;

    public WeaponStats weaponStats;

    public float cooldown = 1f;
    float timer;

    public void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0f)
        {
            Attack();
            timer = cooldown;
        }
    }

    public virtual void SetData(WeaponData wd)
    {
        weaponData = wd;
        cooldown = weaponData.stats.cooldown;

        weaponStats = new WeaponStats(wd.stats.damage, wd.stats.cooldown);
    }

    public abstract void Attack();
}
