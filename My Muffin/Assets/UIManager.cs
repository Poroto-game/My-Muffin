using RainbowArt.CleanFlatUI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public ProgressBarPattern muffinHPSlider;
    private Muffin muffin;

    
    void Start()
    {
        muffin = GameObject.Find("Muffin").GetComponent<Muffin>();
        muffinHPSlider.CurrentValue = muffin.muffinHP;
    }

    
    void Update()
    {
        muffinHPSlider.CurrentValue = muffin.muffinHP;
    }
}
