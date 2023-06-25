using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class HungryGageScript : MonoBehaviour
{
    public UnityEngine.UI.Slider slider;
    public PlayerScript playerScript;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        float fillAmount=playerScript.HungerLevel/playerScript.MaxHungerLevel;
        this.slider.value = fillAmount;
    }
}
