using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    // Asigna el botón desde el inspector
    public Button jugarButton;

    void Start()
    {
        // Asegúrate de que el botón esté asignado
        if (jugarButton != null)
        {
            jugarButton.onClick.AddListener(CargarDribbleDash);
        }
    }

    void CargarDribbleDash()
    {
        // Cambia a la escena "DribbleDash"
        SceneManager.LoadScene("Dribble Dash");
    }
}
