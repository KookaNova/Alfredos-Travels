using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnFunctions : MonoBehaviour
{
    public int A;
    public int B;
    public int C;

    private int Add()
    {
        return A + B;
    }

    private int Subtract()
    {
        return A - B;
    }
    
    void Start()
    {
        C = Add();
        C = Subtract();
    }

    void Update()
    {
        
    }
}
