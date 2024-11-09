using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource sfxAudioSource, musicAudioSource;
    public static SoundManager Instance { get; private set; }

    private bool isMuted = false; // Variable para seguir el estado de mute

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    // Método para alternar el estado de mute
    public void ToggleMute()
    {
        isMuted = !isMuted; // Cambia el estado de mute
        sfxAudioSource.mute = isMuted;
        musicAudioSource.mute = isMuted;
    }

    // Método para verificar el estado de mute desde otros scripts
    public bool IsMuted()
    {
        return isMuted;
    }

    // Método para reproducir un efecto de sonido
    public void ReproducirSonido(AudioClip audio)
    {
        if (!isMuted) // Solo reproduce si no está en mute
        {
            sfxAudioSource.PlayOneShot(audio);
        }
    }

    public bool GetIsMusicPlaying()
    {
        return !isMuted && musicAudioSource.isPlaying;
    }
}
