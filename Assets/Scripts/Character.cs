using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;

public class Character : MonoBehaviour
{
    public Rigidbody2D rb;
    public float Speed,JumpSpeed;
    private float HorizontalInput;
    private bool Jumping;

    void Start()
    {
        
    }


    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        rb.velocity=new Vector2(HorizontalInput*Speed,rb.velocity.y);

        if(Input.GetKeyDown(KeyCode.Space) && !Jumping)
        {
            Jump();
        }
      
    }

    public void Jump()
    {
        rb.AddForce(Vector2.up * JumpSpeed);
        Jumping = true;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag== "Ground")
        {
            Jumping= false;
        }
    }

   
}
