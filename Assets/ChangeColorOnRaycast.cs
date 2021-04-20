using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnRaycast : MonoBehaviour
{
    public Material materialACambiar;

    private void Update()
    {
        //RaycastHit hit;
        RaycastHit[] hits = Physics.RaycastAll(transform.position, transform.forward);
        Debug.DrawRay(transform.position, transform.forward * 100, Color.red);

        
        //if(Physics.Raycast(transform.position, -transform.forward, out hit))
        //{
        //    hit.transform.GetComponent<Renderer>().material = materialACambiar;
        //}
        foreach (RaycastHit r in hits)
        {
            r.transform.GetComponent<OnDetectRaycast>().Detect(true);

            r.transform.GetComponent<Health>().TakeDamage(1);
        }
        

    }


}
