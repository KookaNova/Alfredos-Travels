﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    [SerializeField] private float _value;

    public float Value
    {
        get { return _value;}
        set { this._value = value; }
    }

    public void UpdateValue(float floatInput)
    {
        Value += floatInput;
    }

    public void UpdateValue(FloatData dataObj)
    {
        Value += dataObj.Value;
    }
}
