using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBar : MonoBehaviour
{
    public Slider healthSlider;
    // Start is called before the first frame update
    public void setMaxHP(float max)
    {

        healthSlider.maxValue = max;
        healthSlider.value = max;

    }

    public void SetHP(float hpLevel)
    {

        healthSlider.value = hpLevel;

    }
}
