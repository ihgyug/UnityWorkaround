using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownMovementSctipt: MonoBehaviour
{
    public float speed = 1f;
    private Vector2 moveVelocity;

    private Rigidbody2D body;
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;
    }

    private void FixedUpdate()
    {
        body.MovePosition(body.position + moveVelocity * Time.fixedDeltaTime);
    }
}
