using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeOnMist : MonoBehaviour
{
    public Sprite original, mistVersion;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Mist"))
        {
            GetComponent<SpriteRenderer>().sprite = mistVersion;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Mist"))
        {
            GetComponent<SpriteRenderer>().sprite = original;
        }
    }
}
