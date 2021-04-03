using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(BoxCollider2D))]
public class CharacterController2D : MonoBehaviour, ControlInputs.IPlayerActions
{
    public Animator animator;
    public GameObject artObj;
    public float speed = 1f, jump = 1f, gravity = 1f, acceleration = 1f, deceleration = .5f;
    private Vector2 _moveVec, _currentPosition;
    private ControlInputs _controls;
    private BoxCollider2D characterCollider;
    private bool isGrounded;

    void Awake(){
        characterCollider = GetComponent<BoxCollider2D>();
        _controls = new ControlInputs();
        _controls.Player.Move.performed += OnMove;
        _controls.Player.Jump.performed += OnJump;
    } 

    private void Update() {
        //tells the object how to move
        if(_moveVec.x != 0){
            _currentPosition.x = Mathf.MoveTowards(_currentPosition.x, speed * _moveVec.x, acceleration * Time.deltaTime);

        }
        else{
            _currentPosition.x = Mathf.MoveTowards(_currentPosition.x, 0, Time.deltaTime);
        }

        //code to add gravity when not grounded
        //_currentPosition.y -= gravity * Time.deltaTime;
        //actually moves object
        transform.Translate(_currentPosition * Time.deltaTime);
        //detect collisions, using translate means this isn't an automatic process.
        Collider2D[] collisions = Physics2D.OverlapBoxAll(transform.position, characterCollider.size, 0);
        foreach (Collider2D hit in collisions)
        {
            
        }


        //play walking animation
        if(_moveVec.x != 0){
            animator.SetBool("isWalking", true);
        }
        else{
            animator.SetBool("isWalking", false);
        }
        FlipSprite();


    }

    private void FlipSprite(){
        if(_moveVec.x < 0){
            artObj.transform.localScale = new Vector3(-1, 1, 1);
        }
        if(_moveVec.x > 0){
            artObj.transform.localScale = new Vector3(1, 1, 1);
        }
    }
    public void OnMove(InputAction.CallbackContext value)
    {
        _moveVec = value.ReadValue<Vector2>();
    }

    public void OnJump(InputAction.CallbackContext pressed)
    {
    }

    private void OnEnable() {
        _controls.Player.Enable();
    }
    private void OnDisable() {
        _controls.Player.Disable();
    }
}
