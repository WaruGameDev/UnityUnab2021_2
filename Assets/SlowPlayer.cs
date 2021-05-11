using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowPlayer : MonoBehaviour
{
    private float originalSpeed;
    private float originalGravity;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            originalSpeed = other.GetComponent<Movement>().speed;
            originalGravity = other.GetComponent<Rigidbody2D>().gravityScale;
            other.GetComponent<Rigidbody2D>().gravityScale /= 2;
            other.GetComponent<Movement>().speed /= 2;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            
            other.GetComponent<Movement>().speed = originalSpeed;
            other.GetComponent<Rigidbody2D>().gravityScale = originalGravity;
        }
    }
}
