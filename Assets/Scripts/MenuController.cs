using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    // Asigna el botón desde el inspector
    public Button jugarButton;
    [SerializeField] private AudioClip startSound;
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
        SoundManager.Instance.ReproducirSonido(startSound);
        SoundManager.Instance.GetIsMusicPlaying();
    }
}
