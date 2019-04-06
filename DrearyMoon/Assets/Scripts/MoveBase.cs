using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MoveBase : ScriptableObject
{
    public float Speed, JumpSpeed, Gravity;
    public Animator PlayerAnimator;
   
    protected Vector3 _position;
    
    public abstract void Move(CharacterController _controller);
}
