using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;
[CreateAssetMenu]
public class MoveWithAxis : MoveBase
{
    public override void Move(CharacterController controller)
   {
      if (Input.GetAxis("Vertical") > 0 || Input.GetAxis("Vertical") < 0)
      {
          _position.y = Input.GetAxis("Vertical") * Speed * Time.deltaTime;
      }
      else
      {
          _position.y = Gravity * Time.deltaTime;
      }

       _position.x = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
       controller.Move(_position);
   }
}
