using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public float speed = 500;
    public float jumpForce = 100;
    private Rigidbody2D rb;
    public Transform groundCheck;
    public float distanceFromTheFloor = .1f;
    public LayerMask platform;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Debug.DrawRay(groundCheck.position, -groundCheck.up * distanceFromTheFloor);
        float x = Input.GetAxis("Horizontal");
        Move(x * speed * Time.deltaTime);
        if(Input.GetButtonDown("Jump") && IsGround())
        {
            Jump();
        }
    }
    public void Move(float x)
    {
        rb.velocity = new Vector2(x, rb.velocity.y);
    }
    public void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }
    public bool IsGround()
    {
        return Physics2D.Raycast(groundCheck.position, -groundCheck.up, distanceFromTheFloor, platform);
    }
}
