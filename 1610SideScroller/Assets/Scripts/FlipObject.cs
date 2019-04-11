using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipObject : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        transform.Rotate(0, 180, 0);
    }
}
