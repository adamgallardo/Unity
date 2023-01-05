using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XPManager : MonoBehaviour
{
    int lvl = 1;
    int xp = 0;
    [SerializeField] XPBar xpbar;

    int XPNextLevel
    {
        get { return lvl*100; }
    }

    private void Start()
    {
        xpbar.UpdateXpSlider(xp, XPNextLevel);
        xpbar.UpdateText(lvl);
    }

    public void GainXP (int amount)
    {
        xp += amount;
        CheckXP();
        xpbar.UpdateXpSlider(xp,XPNextLevel);
    }

    private void CheckXP()
    {
        if (xp >= XPNextLevel)
        {
            xp -= XPNextLevel;
            lvl += 1;
            xpbar.UpdateText(lvl);
        }
    }
}
