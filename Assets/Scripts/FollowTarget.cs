using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform target;
    public bool following = true;
    public float speed = 2;
    public Vector2 directionFollow;

    private void Awake()
    {
        target = GameObject.FindGameObjectWithTag("Player").transform;
    }
    private void Update()
    {
        if(following && target != null)
        {
            DirectionToGo();
            transform.Translate(directionFollow * speed * Time.deltaTime);
        }
    }
    public void DirectionToGo()
    {
        directionFollow = (target.position - transform.position).normalized;
    }
}
