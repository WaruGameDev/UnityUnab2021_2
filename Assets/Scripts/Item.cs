using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public string itemName;
    
    public enum TIPOS_MATERIAL
    {
        MADERA,
        PIEDRA,
        TIERRA
    }
    public TIPOS_MATERIAL tiposDeMaterial;
    //public Color colorPiedra;

    private void Start()
    {
        transform.name = tiposDeMaterial.ToString();
        //GetComponent<SpriteRenderer>().color
        switch(tiposDeMaterial)
        {
            case TIPOS_MATERIAL.MADERA:
                GetComponent<SpriteRenderer>().color = Color.yellow;                
                break;
            case TIPOS_MATERIAL.PIEDRA:
                GetComponent<SpriteRenderer>().color = Color.gray;
                break;
            case TIPOS_MATERIAL.TIERRA:
                GetComponent<SpriteRenderer>().color = Color.green;
                break;
        }
        
    }
}
