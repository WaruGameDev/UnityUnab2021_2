using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject bubble;
    public GameObject bomb;

    public enum POWERUP_TYPE
    {
        BOMB,
        BUBBLE
    }
    public POWERUP_TYPE powerUp = POWERUP_TYPE.BUBBLE;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            if(powerUp == POWERUP_TYPE.BUBBLE)
            {
               
                Instantiate(bubble, other.transform);
            }
            if(powerUp == POWERUP_TYPE.BOMB)
            {
                Instantiate(bomb, other.transform.position, Quaternion.identity);
            }
            Destroy(gameObject);
        }
        
    }
}
