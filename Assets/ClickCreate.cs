using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCreate : MonoBehaviour
{
    public GameObject createdObject;
    public Vector3 worldPosition;

    private void Update()
    {
        // funciona en 2D
        //if (Input.GetButtonDown("Fire1"))
        //{
        //    Vector3 mousePos = Input.mousePosition;            
        //    Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePos);            
        //    Create(new Vector3(worldPosition.x, worldPosition.y, 0));
        //}   
        if (Input.GetButtonDown("Fire1"))
        {
            worldPosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,
                Input.mousePosition.y, 10f));
            Create(worldPosition);
        }
    }
    public void Create(Vector3 pos)
    {
        Instantiate(createdObject, pos, Quaternion.identity);
    }
}
