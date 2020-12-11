using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{

    public Slider slide;

    public intData healthVal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void MaxSlide(int health)

    {
        slide.maxValue = healthVal.value;
        slide.value = healthVal.value; 

    }
    public void BarHealth(int health)
    {

        slide.value = healthVal.value;
                }
}
