using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeClass : MonoBehaviour
{
    public ClassCat.CLASS_CAT newClass;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            ClassCat classCat = other.GetComponent<ClassCat>();
            classCat.ChangeClassCat(newClass);
        }
        
    }
}
