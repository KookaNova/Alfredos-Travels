using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMoveCharacter : MonoBehaviour
{
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
        if (_controller.isGrounded && Input.GetButton("Jump"))
        {
            _position.y = JumpSpeed * Time.deltaTime;
        }
      
        _position.x = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        _position.y += Gravity * Time.deltaTime;
        _controller.Move(_position);
    }
}
