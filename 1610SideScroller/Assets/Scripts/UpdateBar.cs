using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UpdateBar : MonoBehaviour
{
    public UnityEvent DeathEvent;
    
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

    void Death()
    {
        
    }

}
