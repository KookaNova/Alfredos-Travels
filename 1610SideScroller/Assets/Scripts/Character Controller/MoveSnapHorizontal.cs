using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSnapHorizontal : MonoBehaviour
{
    public float Speed, JumpSpeed, Gravity;
    public Transform Location;
    
    public int Setter;
    
    private bool _isChangingLane;
    private Vector3 _position;
    private CharacterController _controller;
    
    private void Start()
    {
        _controller = GetComponent<CharacterController>();
        _isChangingLane = false;
    }
    
    private void Update()
    {
        if (Input.GetKeyDown("d") || Input.GetKeyDown("a"))
        {
            _isChangingLane = true;
        }

        if (Input.GetKeyDown("d"))
        {
            Setter = Setter + 1;
        }
        if (Input.GetKeyDown("a"))
        {
            Setter = Setter - 1;
        }
        if (Setter == 2 && _isChangingLane == true)
        {
            Location.position = new Vector3(1.5f, 0, 0);
        }
        if (Setter == 1 && _isChangingLane == true)
        {
            Location.position = new Vector3(0, 0, 0);
        }
        if (Setter == 0 && _isChangingLane == true)
        {
            Location.position = new Vector3(-1.5f, 0, 0);
        }
        
        
        _position.y += Gravity * Time.deltaTime;
        _controller.Move(_position);
    }
}

//if (Input.GetKeyDown("d"))
//{
//Setter = Setter + 1;
//}
//
//if (Input.GetKeyDown("a"))
//{
//Setter = Setter - 1;
//}
//
//if (Setter == 2)
//{
//transform.position = new Vector3(1.5f, _position.y, _position.z);
//}
//        
//else if (Setter >=2)
//{
//Setter = 2;
//}
//        
//if (Setter == 1)
//{
//transform.position = new Vector3(0, _position.y, _position.z);
//}
//        
//else if (Setter <= 0)
//{
//Setter = 0;
//}
//        
//if (Setter == 0)
//{
//transform.position = new Vector3(-1.5f, _position.y, _position.z);
//}
//        
//if (_controller.isGrounded)
//            
//if (Input.GetButton("Jump"))
//{
//_position.y = JumpSpeed * Time.deltaTime;
//}
