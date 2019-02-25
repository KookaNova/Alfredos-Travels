using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Conditionals : MonoBehaviour
{
    public bool CanWalk;
    public int Number;
    public string Password;

    void Update()
    {
        if (CanWalk)
        {
            print("True");
        }
        else
        {
            print(false);
        }

        print(Number >= 10) "Greater" : "Lesser");

        print(Password == "S4LV4D0R" ? "The Password is Correct" : "The Password is Incorrect");
    }

}
//how to make a light switch?
//create an if statement and an event
//make a bool turn on and off an event or something