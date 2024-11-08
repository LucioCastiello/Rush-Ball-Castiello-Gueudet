using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public GameObject panelCreditos;
    public GameObject panelTrofeo;

    // Función para activar el panel de créditos
    public void ActivarPanel()
    {
        panelCreditos.SetActive(true);
    }

    // Función para activar el panel de trofeos
    public void ActivarPanelTrofeo()
    {
        panelTrofeo.SetActive(true);
    }

    // Función para desactivar el panel de créditos
    public void DesactivarPanel()
    {
        panelCreditos.SetActive(false);
    }

    // Función para desactivar el panel de trofeos
    public void DesactivarPanelTrofeo()
    {
        panelTrofeo.SetActive(false);
    }

    // Función que comienza el juego
    public void EmpezarJuego()
    {
        // Reiniciar los valores en el GameManager
        GAMEMANAGER.Instance.Reiniciar();

        // Cargar la escena del juego
        SceneManager.LoadScene("GameScene"); // Asegúrate de reemplazar esto con el nombre correcto de tu escena de juego
    }
}
