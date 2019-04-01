using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseDirection : MonoBehaviour
{
    void Update()
    {
        Vector3 characterScale = transform.localScale;

        characterScale.x = -1;
            
        transform.localScale = characterScale;
    }
}
