using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject bubble;
    public GameObject bomb;
    public GameObject slowDownBullet;
    public GameObject mobilShield;

    public enum POWERUP_TYPE
    {
        BOMB,
        BUBBLE,
        SLOWDONW_BULLET,
        MEDKIT,
        SHIELD
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
            if(powerUp == POWERUP_TYPE.SLOWDONW_BULLET)
            {
                other.GetComponent<Shoot>().bullet = slowDownBullet;
            }
            if(powerUp == POWERUP_TYPE.MEDKIT)
            {
                other.GetComponent<Health>().TakeDamage(-10);
            }
            if(powerUp == POWERUP_TYPE.SHIELD)
            {
                Instantiate(mobilShield, other.transform);
            }
            Destroy(gameObject);

        }
        
    }
}
