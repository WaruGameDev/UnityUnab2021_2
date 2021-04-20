using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RequestItem : MonoBehaviour
{
    //public string itemRequested;
    public Item.TIPOS_MATERIAL materialAPedir;
    public bool ready;
    public List<string> dialogosPj;

    private void Update()
    {
        if(ready)
        {
            transform.Rotate(Vector3.forward * 5);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            if(!ready)
            {
                DialogoManager.instance.ShowDialogue(dialogosPj[0]);
                Inventario inventario = collision.GetComponent<Inventario>();
                foreach (GameObject g in inventario.inventario)
                {
                    if (g.GetComponent<Item>().tiposDeMaterial == materialAPedir)
                    {
                        DialogoManager.instance.ShowDialogue(dialogosPj[1]);
                        inventario.inventario.Remove(g);
                        ready = true;
                        return;
                    }
                }
            }
            else
            {
                DialogoManager.instance.ShowDialogue(dialogosPj[2]);
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            DialogoManager.instance.HideDialogue();
        }
    }
}
