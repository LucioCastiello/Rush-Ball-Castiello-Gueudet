using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
   
    public Button jugarButton;
    [SerializeField] private AudioClip startSound;
    void Start()
    {
        
        if (jugarButton != null)
        {
            jugarButton.onClick.AddListener(CargarDribbleDash);
        }
    }

    void CargarDribbleDash()
    {
      
        SceneManager.LoadScene("Dribble Dash");
        SoundManager.Instance.ReproducirSonido(startSound);
        SoundManager.Instance.GetIsMusicPlaying();
    }
}
