using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMove : MonoBehaviour
{
    public float Speed;
    
    private CharacterController _controller;
    private Vector3 _position;
    
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0 || Input.GetAxis("Horizontal") < 0)
        {
            _position.x = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
            _controller.Move(_position);
        }
    }
}
