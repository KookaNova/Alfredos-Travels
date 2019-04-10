using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateObj : MonoBehaviour
{
   public float SpeedX, SpeedY, SpeedZ;
   
   private void FixedUpdate()
   {
      transform.Translate(SpeedX, SpeedY, SpeedZ * Time.deltaTime);
   }
}
