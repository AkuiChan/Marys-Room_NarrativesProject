using UnityEngine;
using System.Collections;

public class ExampleClass : MonoBehaviour
{
    public CharacterController characterController;
    public Animator m_Animator;
    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (characterController.isGrounded)
        {

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection *= speed;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }

        moveDirection.y -= gravity * Time.deltaTime;

        // Move the controller
        characterController.Move(moveDirection * Time.deltaTime);


        //Check if movement keys are pressed, if yes set isMoving paramater of assigned Animator true.
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            m_Animator.SetBool("isMoving", true);
        }
        else
            m_Animator.SetBool("isMoving", false);


        //Check if space key is pressed, if yes set isJumping paramater of assigned Animator true.
        if (Input.GetKey(KeyCode.Space))
        {
            m_Animator.SetBool("isJumping", true);
        }
        else
            m_Animator.SetBool("isJumping", false);
    }
}