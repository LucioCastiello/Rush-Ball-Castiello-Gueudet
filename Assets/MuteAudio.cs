using  UnityEngine;
using UnityEngine.UI;

public class MuteAudio : MonoBehaviour
{
    [SerializeField] private Sprite audioOnSprite;    // Sprite para el audio activado
    [SerializeField] private Sprite audioOffSprite;   // Sprite para el audio muteado
    private Image buttonImage;                         // Referencia a la imagen del botón

    private void Start()
    {
        buttonImage = GetComponent<Image>(); // Obtiene el componente Image del botón
        UpdateButtonSprite();                // Configura el sprite inicial
    }

    public void OnMuteButtonClick()
    {
        SoundManager.Instance.ToggleMute();  // Alterna el estado de mute en SoundManager
        UpdateButtonSprite();                // Actualiza el sprite
    }

    private void UpdateButtonSprite()
    {
        // Cambia el sprite según el estado de mute
        if (SoundManager.Instance.IsMuted())
        {
            buttonImage.sprite = audioOffSprite;  // Muestra el sprite de mute
        }
        else
        {
            buttonImage.sprite = audioOnSprite;   // Muestra el sprite de audio activado
        }
    }
}
