using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class O2Bar : MonoBehaviour
{

    public Slider slider;

    
    // Start is called before the first frame update

    public void setMaxo2(float max)
    {

        slider.maxValue = max;
        slider.value = max;

    }

    public void Seto2(float o2Level)
    {

        slider.value = o2Level;

    }

}
