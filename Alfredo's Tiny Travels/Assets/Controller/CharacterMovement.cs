using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class CharacterMovement : MonoBehaviour, ControlInputs.IPlayerActions
{
    public Animator animator;
    public float speed = 1f, jump = 1f, gravity = 1f, acceleration = 1f, deceleration = .5f;
    private Vector2 _moveVec, _currentVec;
    private ControlInputs _controls;
    private CharacterController2D _character;

    void Awake(){
        _character = GetComponent<CharacterController>();
        _controls = new ControlInputs();
        _controls.Player.Move.performed += OnMove;
        _controls.Player.Jump.performed += OnJump;
    } 

    private void Update() {

        if(_moveVec.x != 0){
            _currentVec.x = Mathf.MoveTowards(_currentVec.x, speed * _moveVec.x, acceleration * Time.deltaTime);

        }
        else{
            _currentVec.x = Mathf.MoveTowards(_currentVec.x, 0, Time.deltaTime);
        }
        //play walking animation
        if(_moveVec.x != 0){
            animator.SetBool("isWalking", true);
        }
        else{
            animator.SetBool("isWalking", false);
        }
        if(_character.isGrounded == false){
            _currentVec.y -= gravity * Time.deltaTime;
        }
        FlipSprite();


        transform.Translate(_currentVec * Time.deltaTime);

        Collider2D[] hits = Physics2D.OverlapBoxAll(transform.position, boxCollider.size, 0);

        foreach (Collider2D hit in hits)
            {
	            if (hit == boxCollider)
		        continue;

	            ColliderDistance2D colliderDistance = hit.Distance(boxCollider);

	            if (colliderDistance.isOverlapped)
	            {
		            transform.Translate(colliderDistance.pointA - colliderDistance.pointB);
	            }
            }
    }

    private void FlipSprite(){
        if(_moveVec.x < 0){
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if(_moveVec.x > 0){
            transform.localScale = new Vector3(1, 1, 1);
        }
    }
    public void OnMove(InputAction.CallbackContext value)
    {
        _moveVec = value.ReadValue<Vector2>();
    }

    public void OnJump(InputAction.CallbackContext pressed)
    {
        if(_character.isGrounded){
            _currentVec.y += jump;
        }
    }

    private void OnEnable() {
        _controls.Player.Enable();
    }
    private void OnDisable() {
        _controls.Player.Disable();
    }
}
