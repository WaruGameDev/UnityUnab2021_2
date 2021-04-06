using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowEffect : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(GetComponent<Bullet>().target))
        {
            FollowTarget followTarget = other.GetComponent<FollowTarget>();
            if(!followTarget.slowDown)
            {
                followTarget.slowDown = true;
                followTarget.speed /= 2;
            }
        }
    }
    
}
