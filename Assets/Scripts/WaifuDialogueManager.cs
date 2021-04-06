using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WaifuDialogueManager : MonoBehaviour
{
    public static WaifuDialogueManager instance;
    public TextMeshProUGUI textoDialogo;
    public List<string> dialogos;
    public int index;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        ShowDialogue();
    }
    public void ShowDialogue()
    {
        textoDialogo.text = dialogos[index];
    }
    public void NextDialogue()
    {
        index++;
        if(index < dialogos.Count)
        {
            ShowDialogue();
        }
        else
        {
            index = 0;
            ShowDialogue();
        }
    }
}
