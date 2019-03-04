using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MoveCharacter : MonoBehaviour
{
   public MoveBase ControlType;
   private CharacterController _controller;

   void Start()
   {
      _controller = GetComponent<CharacterController>();
   }

   void Update()
   {
      ControlType.Move(_controller);
   }
}