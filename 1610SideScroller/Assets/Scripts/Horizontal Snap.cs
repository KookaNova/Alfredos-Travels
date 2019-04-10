//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//
//public class HorizontalSnap : MonoBehaviour
//{
//    private Vector3 _moveDirection = Vector3.zero;
//    public float gravity = 20f;
//    private CharacterController _controller;
// 
//    private bool isChangingLane = false;
//    private Vector3 NewLane;
////distance character will move sideways
//    private Vector3 MoveDistance = Vector3.right * 2f;
// 
//    public float SideWaysSpeed = 5.0f;
// 
//    public float JumpSpeed = 8.0f;
//    public float Speed = 6.0f;
////Max gameobject
//    public Transform CharacterGO;
//    
//    void Start()
//    {
//        _moveDirection = transform.forward;
//        _moveDirection = transform.TransformDirection(_moveDirection);
//        _moveDirection *= Speed;
//        _controller = GetComponent<CharacterController>();
//    }
//
//    private void DetectJumpOrSwipeLeftRight()
//    {
//        if (_controller.isGrounded && Input.GetAxis("Horizontal") && inputDirection == InputDirection.Top && !isChangingLane)
//        {
//            _moveDirection.y = JumpSpeed;
//            anim.SetBool(Constants.AnimationJump, true);
//        }
//        else
//        {
//            anim.SetBool(Constants.AnimationJump, false);
//        }
//        if (_controller.isGrounded && inputDirection.HasValue && !isChangingLane)
//        {
//            isChangingLane = true;
// 
//            if (inputDirection == InputDirection.Left)
//            {
//                NewLane = transform.position - MoveDistance;
//                _moveDirection.x = -SideWaysSpeed;
//            }
//            else if (inputDirection == InputDirection.Right)
//            {
//                NewLane = transform.position + MoveDistance;
//                _moveDirection.x = SideWaysSpeed;
//            }
//        }
//    }
//
//    private void Update()
//    {
//        if (isChangingLane)
//        {
//            if (Mathf.Abs(transform.position.x - NewLane.x) < 0.1f)
//            {
//                isChangingLane = false;
//                _moveDirection.x = 0;
//            }
//        }
//    }
//}
