using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class ForwardConstant : MoveBase
{
    public override void Move(CharacterController controller)
    {
        if (controller.isGrounded && Input.GetButton("Jump"))
        {
            _position.y = JumpSpeed * Time.deltaTime;
        }

        _position.z = Speed * Time.deltaTime;
        _position.x = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        _position.y += Gravity * Time.deltaTime;
        controller.Move(_position);
    }
}
