using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CherryBar : MonoBehaviour
{
    public Slider cherrySlider;
    // Start is called before the first frame update
    public void setMaxcherry(float max)
    {

        cherrySlider.maxValue = max;
        cherrySlider.value = max;

    }

    public void Setcherry(float cherryAmount)
    {

        cherrySlider.value = cherryAmount;

    }
}
