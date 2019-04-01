using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class SimpleMoveCharacter : MonoBehaviour
{
    public float Speed;
    public float JumpSpeed;
    public float Gravity;
    
    private float _increment = 5;
    private float _maxSpeed = 40;

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
        
        
// acceleration
        if (Input.GetAxisRaw("Horizontal") < 0 || (Input.GetAxisRaw("Horizontal") > 0))
        {
            Speed += _increment * Time.deltaTime;
        }
        else
        {
            Speed -= _increment * 10 * Time.deltaTime;
        }
        Speed = Mathf.Clamp (Speed, 10, _maxSpeed);     
 }
    public Vector3 Move()
    {
        return _position;
    }
}
