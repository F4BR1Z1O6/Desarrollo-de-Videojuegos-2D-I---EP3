using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGameOver : MonoBehaviour
{
    public string Menu;

    void Start()
    {
        Invoke("CambiarEscena", 6f); 
    }

    void CambiarEscena()
    {
        SceneManager.LoadScene(0);
    }

    public void Salir()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}

