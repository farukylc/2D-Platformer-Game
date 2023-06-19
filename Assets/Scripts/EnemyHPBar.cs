using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHPBar : MonoBehaviour
{

    public Slider slider;
    // Start is called before the first frame update
    public void enemyMaxHP(float max)
    {

        slider.maxValue = max;
        slider.value = max;

    }

    public void enemyHP(float o2Level)
    {

        slider.value = o2Level;

    }
}
