using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource sfxAudioSource, musicAudioSource;
    public static SoundManager Instance { get; private set; }

    private bool isMusicPlaying;

    // Start is called before the first frame update

    private void Awake()
    {
        if  (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
      
    }
    void Start()
    {
       
    }

    public void ReproducirSonido(AudioClip audio)
    {
        sfxAudioSource.PlayOneShot(audio);
    }

    public bool GetIsMusicPlaying()
    {
        return isMusicPlaying;
    }
}

