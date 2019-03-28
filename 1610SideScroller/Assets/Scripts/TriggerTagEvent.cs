using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Experimental.UIElements;

public class TriggerTagEvent : MonoBehaviour
{
    public UnityEvent EnterEvent, ExitEvent;
    public StringData Tag;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(Tag.Output))
        {
            EnterEvent.Invoke();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        ExitEvent.Invoke();
    }
}
