using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeObjX : MonoBehaviour
{
    public float ObjX, ObjY;
    void Update()
    {
        transform.Translate(ObjX, ObjY, 0f);
    }
}
