using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateBar : MonoBehaviour
{
    private Image BarImage;
    public FloatData FillNumber;
    
    void Start()
    {
        BarImage = GetComponent<Image>();
    }

    void Update()
    {
        BarImage.fillAmount = FillNumber.Value;
    }
}
