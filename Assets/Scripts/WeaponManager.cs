using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    [SerializeField] Transform weaponObjectsContainer;

    [SerializeField] WeaponData startingWeapon;
    [SerializeField] WeaponData unlockedWeapon1;

    public void Start()
    {
        AddWeapon(startingWeapon);
        AddWeapon(unlockedWeapon1);
    }

    public void AddWeapon(WeaponData weaponData)
    {
        GameObject weaponGameObject = Instantiate(weaponData.weaponPrefab,weaponObjectsContainer);

        weaponGameObject.GetComponent<WeaponAttacks>().SetData(weaponData);
    }
}
