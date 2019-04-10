using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveZConstant : MonoBehaviour
{
    public float Speed;
    public float JumpSpeed;
    public float Gravity;
    public int Setter;

    public Transform Left, Middle, Right;

    private Vector3 _position;
    private CharacterController _controller;

    private void Start()
    {
        _controller = GetComponent<CharacterController>();
        Setter = 1;
    }
    
    private void Update()
    {
        if (Input.GetKeyDown("d"))
        {
            Setter = Setter + 1;
        }

        if (Input.GetKeyDown("a"))
        {
            Setter = Setter - 1;
        }

        if (Setter == 2)
        {
            transform.position = Right.position;
        }
        
        else if (Setter >=2)
        {
            Setter = 2;
        }
        
        if (Setter == 1)
        {
            transform.position = Middle.position;
            print("Middle");
        }
        
        else if (Setter <= 0)
        {
            Setter = 0;
        }
        
        if (Setter == 0)
        {
            transform.position = Left.position;
        }

        if (_controller.isGrounded)
            
            if (Input.GetButton("Jump"))
            {
                _position.y = JumpSpeed * Time.deltaTime;
            }
        
        _position.y += Gravity * Time.deltaTime;
        _controller.Move(_position);
        
    }
}
