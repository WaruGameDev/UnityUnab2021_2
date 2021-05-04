using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DragginRotate : MonoBehaviour
{
    public Transform pivot;
    public Transform refPos;


    private void OnMouseDrag()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        refPos.position = mousePos;


        if(mousePos != Vector2.zero)
        {           
            Quaternion rotation = Quaternion.LookRotation(refPos.position, Vector3.right);
            pivot.rotation = rotation;
        }
    }
}
