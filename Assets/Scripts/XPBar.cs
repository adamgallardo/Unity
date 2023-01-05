using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class XPBar : MonoBehaviour
{
    [SerializeField] Slider slider;
    [SerializeField] TMPro.TextMeshProUGUI lvl;

    public void UpdateXpSlider(int current, int target)
    {
        slider.maxValue = target;
        slider.value = current;
    }

    public void UpdateText(int level)
    {
        lvl.text = "LVL: " + level.ToString();
    }
}
