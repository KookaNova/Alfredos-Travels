using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTimeScale : MonoBehaviour
{
    public FloatData TimeScale;

    public void ChangeTime()
    {
        Time.timeScale = TimeScale.Value;
    }
}
