using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDetectRaycast : MonoBehaviour
{
    public Material original, newMaterial;
    public bool isOnRayCast;

    private void Update()
    {
        if(isOnRayCast)
        {
            GetComponent<Renderer>().material = newMaterial;
        }
        else
        {
            GetComponent<Renderer>().material = original;
        }
        Detect(false);
    }

    public void Detect(bool detected)
    {
        isOnRayCast = detected;
    }


}
