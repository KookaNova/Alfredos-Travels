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
    private Vector2 _moveVec, _currentVec;
    private ControlInputs _controls;
    private BoxCollider2D boxCollider;
    private bool isGrounded;

    void Awake(){
        boxCollider = GetComponent<BoxCollider2D>();
        _controls = new ControlInputs();
        _controls.Player.Move.performed += OnMove;
        _controls.Player.Jump.performed += OnJump;
    } 

    private void Update() {
        //tells objects how to move
        if(_moveVec.x != 0){
            _currentVec.x = Mathf.MoveTowards(_currentVec.x, speed * _moveVec.x, acceleration * Time.deltaTime);

        }
        else{
            _currentVec.x = Mathf.MoveTowards(_currentVec.x, 0, Time.deltaTime);
        }
        //actually moves object
        transform.Translate(_currentVec * Time.deltaTime);
        //code to determine if object is grounded
        Collider2D[] hits = Physics2D.OverlapBoxAll(transform.position, boxCollider.size, 0);

        //code to add gravity when not grounded
        

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
