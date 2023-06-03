using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    PlayerControls controls;
    float direction = 0;
    float jump = 0;
    public float speed = 400f;
    public float jumpSpeed = 5f;
    public Rigidbody2D playerRb;
    bool isGrounded;
    public Transform groundCheck;
    public LayerMask groundMask;

    private void Awake()
    {
        controls = new PlayerControls();
        controls.Enable();

        controls.Land.Move.performed += ctx =>
        {
            direction = ctx.ReadValue<float>();  //default 0 => 0-1
        };

        controls.Land.Jump.performed += ctx => Jump(); 
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.1f, groundMask);
        playerRb.velocity = new Vector2(direction * speed* Time.fixedDeltaTime,playerRb.velocity.y);
    }
   
    void Jump()
    {  
        if(isGrounded)
           playerRb.velocity = new Vector2(playerRb.velocity.x, jumpSpeed);
    }
}
