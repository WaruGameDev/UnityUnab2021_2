using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mochila : MonoBehaviour
{
    public Transform mochilaSpawn;
    public List<Transform> mochilaPositon;

    public int capacityMochila
    {
        get { return 0; }
        set
        {
            capacityMochila = _capacityMochila;            
        }
    }
    public int _capacityMochila;

    private void Start()
    {
        mochilaPositon.Add(mochilaSpawn);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Caja"))
        {
            Apilar(other.gameObject);
        }
    }
    public void Apilar(GameObject aApilar)
    {
        aApilar.transform.position = mochilaPositon[0].position;
        mochilaPositon.Add(aApilar.transform);
        aApilar.transform.SetParent(transform);
        mochilaSpawn.position = new Vector3(mochilaSpawn.position.x, 
            mochilaSpawn.position.y + 1, mochilaSpawn.position.z);
        _capacityMochila++;
        ManagerDoor.instance.AlRecogerCaja();
    }
    public void Soltar(int caja)
    {
        mochilaPositon[caja].gameObject.SetActive(false);
        mochilaPositon.RemoveAt(caja);
        for (int i = 0; i < mochilaPositon.Count; i++)
        {
            if(i == 0)
            {
                mochilaPositon[0].position = mochilaPositon[mochilaPositon.Count - 1].position;
            }
            if(i >= caja)
            {
                mochilaPositon[i].position = new Vector3(mochilaPositon[i].position.x, 
                    mochilaPositon[i].position.y - 1, mochilaPositon[i].position.z);
            }
        }
    }
    

}
