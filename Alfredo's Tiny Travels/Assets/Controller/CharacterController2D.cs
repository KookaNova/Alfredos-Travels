using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(BoxCollider2D))]
public class CharacterController2D : MonoBehaviour, ControlInputs.IPlayerActions
{
    public Animator animator;
    public GameObject artObj;
    public float speed = 10f, jumpHeight = 10f, Acceleration = 6f, deceleration = 6f;
    private float _currentDeceleration, _currentAcceleration;
    private bool isGrounded, isJumping;
    private Vector2 _moveVec, _currentPosition;
    private ControlInputs _controls;
    private BoxCollider2D characterCollider;

    void Awake(){

        
        characterCollider = GetComponent<BoxCollider2D>();
        _controls = new ControlInputs();
        _controls.Player.Move.performed += OnMove;
        _controls.Player.Jump.performed += OnJump;

    } 
    private void OnEnable() {
        _controls.Player.Enable();
    }
    private void OnDisable() {
        _controls.Player.Disable();
    }
    public void OnMove(InputAction.CallbackContext value){
        _moveVec.x = value.ReadValue<Vector2>().x;
    }

    public void OnJump(InputAction.CallbackContext value){
        float pressedValue = value.ReadValue<float>();
        if(pressedValue != 0){
            if(isGrounded == true){
                _currentPosition.y = Mathf.Sqrt(2 * jumpHeight * Mathf.Abs(Physics2D.gravity.y));
                animator.SetBool("jumpPressed", true);
            }
        }
        else{
            animator.SetBool("jumpPressed", false);
        }
    }

    private void Update() {
        if(isGrounded == true){
            _currentAcceleration = Acceleration;
        }
        else{
            _currentAcceleration = Acceleration/2;
            _currentDeceleration = 0;
        }
        //tells the object how to move
        if(_moveVec.x != 0){
            _currentPosition.x = Mathf.MoveTowards(_currentPosition.x, speed * _moveVec.x, _currentAcceleration * Time.deltaTime);
        }
        else{
            _currentPosition.x = Mathf.MoveTowards(_currentPosition.x, 0, _currentDeceleration * Time.deltaTime);
        }
        if(isGrounded == false){
            _currentPosition.y += Physics2D.gravity.y * Time.deltaTime;
        }
        
        //actually moves object
        transform.Translate(_currentPosition * Time.deltaTime);
        //detect collisions, using translate means this isn't an automatic process.
        Collider2D[] collisions = Physics2D.OverlapBoxAll(transform.position, characterCollider.size, 0);
        //for each collider hit, move the object back.
        isGrounded = false;
        foreach (Collider2D hit in collisions)
        {
            if(hit == characterCollider)
                continue;

            ColliderDistance2D colliderDistance = hit.Distance(characterCollider);
            if(colliderDistance.isOverlapped){
                transform.Translate(colliderDistance.pointA - colliderDistance.pointB);
                if(Vector2.Angle(colliderDistance.normal, Vector2.up) > 45){
                    _currentDeceleration = 1000;
                    _currentPosition.x = Mathf.MoveTowards(_currentPosition.x, 0, _currentDeceleration * Time.deltaTime);
                }
                else{
                    _currentDeceleration = deceleration;
                }
                if(Vector2.Angle(colliderDistance.normal, Vector2.up) > 90){
                    
                    _currentPosition.y = _currentPosition.y - 1f;
                }

                //checks if the angle of collision is less than 90
                if(Vector2.Angle(colliderDistance.normal, Vector2.up) < 45 && _currentPosition.y < 0){
                    isGrounded = true;
                    animator.SetBool("isGrounded", true);
                }
            }
        }

        //play animations
        if(_moveVec.x != 0){
            animator.SetBool("isWalking", true);
            animator.SetFloat("Speed", 1);
        }
        else{
            animator.SetBool("isWalking", false);
            animator.SetFloat("Speed", 0);
        }
        if(isGrounded == false){
            animator.SetBool("isGrounded", false);
            animator.SetFloat("Speed", 0);
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
}
