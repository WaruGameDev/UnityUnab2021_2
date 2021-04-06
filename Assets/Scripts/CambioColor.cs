using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioColor : MonoBehaviour
{
    public List<Renderer> cubos;
    public Material colorACambiar;
    public int index;

    private void Start()
    {
        foreach (Transform t in transform)
        {
            cubos.Add(t.GetComponent<Renderer>());            
        }
        //foreach(Renderer r in cubos)
        //{
        //    r.material = colorACambiar;
        //}
        for (int i = 0; i < cubos.Count; i++)
        {
            if(i%2 ==0)
            {
                cubos[i].material = colorACambiar;
            }
            
        }        
    }
    
}
