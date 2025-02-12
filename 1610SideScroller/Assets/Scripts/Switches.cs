﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class Switches : MonoBehaviour
{
    public UnityEvent StartingEvent, PlayingEvent, DyingEvent, EndingEvent;
    public enum States
    {
        Starting,
        Playing,
        Dying,
        Ending
    }

    public States CurrentState;

    private void Update()
    {
        switch (CurrentState)
        {
            case States.Starting:
                StartingEvent.Invoke();
                break;
            case States.Playing:
                PlayingEvent.Invoke();
                break;
            case States.Ending:
                EndingEvent.Invoke();
                break;
            case States.Dying:
                DyingEvent.Invoke();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
