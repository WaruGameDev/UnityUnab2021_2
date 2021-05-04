using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class ContadorDeClickManager : MonoBehaviour
{
    public static ContadorDeClickManager instance;
    public TextMeshProUGUI contador;
    public int contadorBoton;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        contador.text = contadorBoton.ToString();
    }
    public void SumarClick()
    {
        contadorBoton++;
        contador.text = contadorBoton.ToString();
    }
    public void ChangeScene(string name)
    {
        SceneManager.LoadScene(name);
    }
    
}
