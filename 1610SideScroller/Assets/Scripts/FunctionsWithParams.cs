using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionsWithParams : MonoBehaviour
{
    private void Start()
    {
        AddData(12.5f, 8.5f);
    }

    private void Update()
    {
        
    }

    private void AddData(float a, float b)
    {
        print(a + b);
    }

    private void OnTriggerEnter(Collider obj)
    {
        obj.gameObject.SetActive(false);
    }
}
