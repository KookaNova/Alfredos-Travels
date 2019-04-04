using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCharacterSprite : MonoBehaviour
{
    private Vector3 _rotate;
    private const float RotSpeed = 2.5f;
    
    private void Update()
    {
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            transform.rotation = Quaternion.Euler(0,0,--_rotate.z * RotSpeed);
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, ++_rotate.z * RotSpeed);
        }
    }
    
}
