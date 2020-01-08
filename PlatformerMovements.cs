using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerMovements : MonoBehaviour
{
    public float speed = 1f;
    public float jumpForce;
    private float moveInput;

    private Rigidbody2D body;
    private bool facingRight = true;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(moveInput * speed, body.velocity.y);
        FlipHandler();
    }
    
    void FlipHandler()
    {
        void Flip()
        {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
         }
        if (facingRight == false && moveInput > 0)
            {
            Flip();
        } else if (facingRight == true && moveInput< 0)
        {
            Flip();
        }
    }
}
