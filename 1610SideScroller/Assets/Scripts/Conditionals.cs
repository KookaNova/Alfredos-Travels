using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class Conditionals : MonoBehaviour
{
    public UnityEvent OnEvent;

    public UnityEvent OffEvent;
    //should be able to turn on and off anything, not just a light
    
    public bool OnBool;
    public int Number;
    public string Password;

    void Update()
    {
        if (OnBool)
        {
            OnEvent.Invoke();
        }
        else
        {
            OffEvent.Invoke();
        }
        
       // print(Number >= 10) "Greater" : "Lesser");

       // print(Password == "S4LV4D0R" ? "The Password is Correct" : "The Password is Incorrect");
    }

}