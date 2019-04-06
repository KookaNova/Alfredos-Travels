using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class MoveSingleJump : MoveBase
{
   public override void Move(CharacterController _controller)
   {
      if (_controller.isGrounded)
      {
         if (Input.GetButton("Jump"))
         {
            _position.y = JumpSpeed * Time.deltaTime;
         }
      }
      else
      {
         _position.y += Gravity * Time.deltaTime;
      }
      
      _position.x = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
      _controller.Move(_position);
      
      PlayerAnimator.SetFloat("Speed", Mathf.Abs(Speed));
   }
}
