using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateObjZ : MonoBehaviour
{
   public float Speed;
   
   private void FixedUpdate()
   {
      transform.Translate(0f, 0f, Speed * Time.deltaTime);
   }
}
