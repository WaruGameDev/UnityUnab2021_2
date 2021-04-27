using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterTopDown : MonoBehaviour
{
    public float speed = 3;
    public Transform canon;
    public int damage = 1;
    public LineRenderer line;

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        transform.Rotate(transform.up * x * speed);
        if(Input.GetButtonDown("Jump"))
        {
            RaycastHit hit;
            if(Physics.Raycast(canon.position,canon.forward, out hit))
            {                
                line.SetPosition(0, canon.position);
                line.SetPosition(1, hit.point);
                if(hit.transform.CompareTag("Enemy"))
                {
                    Health h = hit.transform.GetComponent<Health>();
                    h.TakeDamage(damage);
                }

            }
        }

    }

}
