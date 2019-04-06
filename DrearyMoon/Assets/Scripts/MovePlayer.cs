using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float Speed, JumpSpeed, Gravity;

    public Animator PlayerAnimator;

    private const float _minSpeed = 9;
    private const float _increment = 1;

    private CharacterController _controller;
    private Vector3 _position;

    private void Start()
    {
        _controller = GetComponent<CharacterController>();
        Speed = _minSpeed;
    }

    private void Update()
    {
        if (_controller.isGrounded)
        {

            if (Input.GetButton("Jump"))
            {
                _position.y = JumpSpeed * Time.deltaTime;
                PlayerAnimator.SetBool("JumpButton", true);
            }

            PlayerAnimator.SetBool("IsGrounded", true);
        }
        else
        {
            _position.y += Gravity * Time.deltaTime;
            PlayerAnimator.SetBool("JumpButton", false);
            PlayerAnimator.SetBool("IsGrounded", false);
        }

        _position.x = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        _controller.Move(_position);

        PlayerAnimator.SetFloat("Speed", Mathf.Abs(Speed));
        // acceleration
        if (Input.GetAxisRaw("Horizontal") < 0 || (Input.GetAxisRaw("Horizontal") > 0))
        {
            Speed += _increment * Time.deltaTime;
        }
        else
        {
            Speed -= _increment * 10 * Time.deltaTime;
        }
        Speed = Mathf.Clamp (Speed, _minSpeed, Speed);     

    }
}
