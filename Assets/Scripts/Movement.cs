using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5;
    public Transform transformAMover;
    public Vector2 directionShoot;
    public bool isUsingMouse =true;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        
        rb.velocity = new Vector2(x, y)*speed * Time.fixedDeltaTime;
        
        if(isUsingMouse)
        {
            float mousePosX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x;
            float mousePosY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y;
            if (mousePosX != 0 || mousePosY != 0)
            {
                directionShoot = (new Vector2(mousePosX, mousePosY) - (Vector2)transform.position).normalized;
            }
            
        }
        else
        {
            float mousePosX = 10*Input.GetAxis("XboxSecondAnalogHorizontal");
            float mousePosY = 10*Input.GetAxis("XboxSecondAnalogVertical");
            if(mousePosX != 0 || mousePosY != 0)
            {
                directionShoot = (new Vector2(mousePosX, mousePosY) - (Vector2)transform.position).normalized;
            }
        }
        

    }
}
