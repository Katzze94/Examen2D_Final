using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public static Animator characterAnimator;

    private Rigidbody2D characterRigidBody;

    private float _horizontalInput;

    [SerializeField] private float _movementSpeed = 5;

    [SerializeField] private float _jumpForce = 5;



    // Update is called once per frame
    void Update()
    {
        Movement();

        if(Input.GetButtonDown("Jump") && GroundSensor.isGrounded)
        {
            Jump();
        }




    }


void Awake()
{

    characterRigidBody = GetComponent<Rigidbody2D>();

    characterAnimator = GetComponent<Animator>();
}

    void FixedUpdate()
    {
         characterRigidBody.velocity = new Vector2(_horizontalInput * _movementSpeed, characterRigidBody.velocity.y);
    }



    void Movement()
    {

        _horizontalInput = Input.GetAxis("Horizontal");


        if(_horizontalInput == 0)
        {
            characterAnimator.SetBool("IsRuning", false);
        }




        if( _horizontalInput < 0)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);

            characterAnimator.SetBool("IsRuning", true);
        }
        else if( _horizontalInput > 0)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            characterAnimator.SetBool("IsRuning", true);
        }




    }


    void Jump()
    {
        characterRigidBody.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
        //characterAnimator.SetBool("IsJumping", true);

    }
}
