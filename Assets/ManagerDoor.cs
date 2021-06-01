using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerDoor : MonoBehaviour
{
    public static ManagerDoor instance;
    public int cantidadCajas;
    public GameObject puerta;


    private void Awake()
    {
        instance = this;
    }

    public void AlRecogerCaja()
    {
        cantidadCajas++;
        if(cantidadCajas >3)
        {
            puerta.SetActive(false);
        }
    }

}
