using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MoveBase : ScriptableObject
{
    public float Speed;
    public float JumpSpeed;
    public float Gravity;
   
    protected Vector3 _position;
    
    public abstract void Move(CharacterController controller);
}
