using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Counter : MonoBehaviour
{

    public UnityEvent OnCountEvent, OnEndEvent;

    public int Value = 3, MinValue = 0;
    public float WaitTime = 1;

    public void StartCounter()
    {
        StartCoroutine(RunCounter());
    }

    private IEnumerator RunCounter()
    {
        var waitObject = new WaitForSeconds(WaitTime);
        
        while (Value > MinValue)
        {
            yield return waitObject;
            OnCountEvent.Invoke();
            Value--;
        }

        yield return waitObject;
        OnEndEvent.Invoke();
    }
    
    //can be used at the start of a racing game.
    //might be able to send low health warnings using float data
    //great for counting down
    //throw a bomb and it waits to explode\
    //platforms that fall after a number of seconds



}
