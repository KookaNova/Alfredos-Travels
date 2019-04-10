using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputEvents : MonoBehaviour
{
    public UnityEvent PosH, NegH, PosV, NegV;

    private void HorizontalEvents()
    {
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            PosH.Invoke();
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            NegH.Invoke();
        }
    }

    private void VerticalEvents()
    {
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            PosV.Invoke();
        }
        if (Input.GetAxisRaw("Vertical") < 0)
        {
            NegV.Invoke();
        }
    }
}
