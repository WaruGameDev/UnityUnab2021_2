using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameManager : MonoBehaviour
{
    public static GameManager staticGameManager;
    public int puntaje;
    public TextMeshProUGUI puntajeText, hpPlayer;
    public Health player;

    private void Awake()
    {
        staticGameManager = this;
    }
    private void Update()
    {
        puntajeText.text = "Puntaje: " + puntaje;
        hpPlayer.text = "HP: " +player.hp;
    }
}
