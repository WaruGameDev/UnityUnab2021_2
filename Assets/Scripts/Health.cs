﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public string nameChar = "";
    public int hp = 5;

    public void TakeDamage(int damage)
    {
        hp -= damage;
        if(hp <= 0)
        {
            Destroy(gameObject);
            print(nameChar + " ha muerto :c");
        }
    }
    private void OnMouseDown()
    {
        TakeDamage(1);
    }

}
