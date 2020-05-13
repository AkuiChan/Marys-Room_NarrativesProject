using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    CharacterController cc;
    public Animator m_Animator;
    private Vector3 moveDirection = Vector3.zero;
    public float speed = 2.0f;
    public float jumpSpeed = 1.0f;
    public float gravity = 20.0f;
    private bool isJump;


    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (cc.isGrounded)
        {
            // We are grounded, so recalculate
            // move direction directly from axes

            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection *= speed;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }

            if (moveDirection != Vector3.zero)
            {
                transform.rotation = Quaternion.LookRotation(moveDirection);
                
            }

            // Rotation for 2.5d 
            // transform.right = Vector3.Slerp(transform.right, Vector3.right * Input.GetAxis("Horizontal"), 0.1f);
        }

        // Apply gravity. Gravity is multiplied by deltaTime twice (once here, and once below
        // when the moveDirection is multiplied by deltaTime). This is because gravity should be applied
        // as an acceleration (ms^-2)
        moveDirection.y -= gravity * Time.deltaTime;

        // Move the controller
        cc.Move(moveDirection * Time.deltaTime);


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
