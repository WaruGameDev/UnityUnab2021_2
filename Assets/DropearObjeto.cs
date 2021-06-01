using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropearObjeto : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            Mochila mochila = other.GetComponent<Mochila>();
            mochila.Soltar(2);
        }
    }
}
