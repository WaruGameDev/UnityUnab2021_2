using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCode : MonoBehaviour
{
    public float speed = 50;
    private void FixedUpdate()
    {
        transform.Rotate(transform.forward * speed * Time.fixedDeltaTime);
    }
}
