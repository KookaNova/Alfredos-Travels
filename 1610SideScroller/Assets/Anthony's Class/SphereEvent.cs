using UnityEngine;
using UnityEngine.Events;

public class SphereEvent : MonoBehaviour
{
    public UnityEvent Event; 
    
    private void OnCollisionEnter2D()
    {
        Event.Invoke();
    }
}



