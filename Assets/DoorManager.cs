using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    public static DoorManager staticDoorManager;
    public GameObject door1, door2;
    public int enemigosEliminados;

    private void Awake()
    {
        staticDoorManager = this;
    }

    private void Update()
    {
        if(enemigosEliminados >=6)
        {
            door1.SetActive(false);
        }
        if(enemigosEliminados >=8)
        {
            door2.SetActive(false);
        }
    }
}
