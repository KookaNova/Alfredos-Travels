using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MoveCharacter : MonoBehaviour
{
//   public UnityEvent OnGrounded, OffGrounded;

   public float Speed;
   public float JumpSpeed;
   public float Gravity;
   
   private CharacterController _controller;
   private Vector3 _position;

   void Start()
   {
      _controller = GetComponent<CharacterController>();
   }

   void Update()
   {
      if (_controller.isGrounded)
      {
         _position.x = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
         _position.y = Input.GetAxis("Vertical") * Speed * Time.deltaTime;
      }

      if (Input.GetButton("Jump"))
      {
         _position.y = JumpSpeed;
      }

      _position.y = _position.y - Gravity * Time.deltaTime;
      
      _controller.Move(_position);
   }
}
