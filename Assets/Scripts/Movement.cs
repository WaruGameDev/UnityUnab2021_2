using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5;
    public Transform transformAMover;
    
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        transformAMover.Translate(transformAMover.right * x * speed * Time.deltaTime);
        transformAMover.Translate(transformAMover.up * y * speed * Time.deltaTime);

    }
}
