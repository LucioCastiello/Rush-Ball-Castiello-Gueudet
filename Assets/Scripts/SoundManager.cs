using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource sfxAudioSource, musicAudioSource, deathaudiosource;
    public static SoundManager Instance { get; private set; }

    private bool isMuted = false;

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

    public void ToggleMute()
    {
        isMuted = !isMuted;
        sfxAudioSource.mute = isMuted;
        musicAudioSource.mute = isMuted;
        deathaudiosource.mute = isMuted;
    }

    public bool IsMuted()
    {
        return isMuted;
    }

    public void ReproducirSonido(AudioClip audio)
    {
        if (!isMuted)
        {
            sfxAudioSource.PlayOneShot(audio);
        }
    }

    public bool GetIsMusicPlaying()
    {
        return !isMuted && musicAudioSource.isPlaying;
    }

    // Nuevo método para reproducir deathaudiosource
    public void ReproducirSonidoMuerte()
    {
        if (!isMuted)
        {
            deathaudiosource.Play();
        }
    }
}

