using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadingManager : MonoBehaviour
{
    public void ChangeScene(int sceneToChange)
    {
        SceneManager.LoadScene(sceneToChange);
    }
}
