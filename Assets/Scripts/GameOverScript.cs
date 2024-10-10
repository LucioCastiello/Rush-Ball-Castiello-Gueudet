using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScript : MonoBehaviour
{
    public void Reiniciar(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }

    public void MenuInicial(string nombre)
    {
        SceneManager.LoadScene(nombre);
    }

    public void Salir()
    {
        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
}
