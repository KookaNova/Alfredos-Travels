using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
   public MoveBase ControlType;
   private CharacterController _controller;

   private void Start()
   {
      _controller = GetComponent<CharacterController>();
   }

   private void Update()
   {
      ControlType.Move(_controller);
   }
}