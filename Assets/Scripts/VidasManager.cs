using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VidasManager : MonoBehaviour
{
    int vidas = 1;
    HUD hud;
    public Animator playerAnimator;  // Asegúrate de que esté declarada aquí
    public string deathAnimationName;

    void Awake()
    {
        hud = FindObjectOfType<HUD>();

        // Opcionalmente, asigna playerAnimator mediante código si no se asigna en el Inspector
        if (playerAnimator == null)
        {
            playerAnimator = GetComponent<Animator>();
            if (playerAnimator == null)
            {
                Debug.LogError("Player Animator no está asignado y no se pudo encontrar un Animator en el GameObject.");
            }
        }
    }

    public void PerderVida()
    {
        vidas -= 1;
        GAMEMANAGER.Instance.vidas = vidas;
        if (vidas == 0)
        {
            StartCoroutine(HandleDeath());
        }
    }

    private IEnumerator HandleDeath()
    {
        Time.timeScale = 0f;

        // Llama al método para reproducir el sonido de muerte
        if (SoundManager.Instance != null)
        {
            SoundManager.Instance.ReproducirSonidoMuerte();
        }

        if (playerAnimator != null)
        {
            playerAnimator.Play(deathAnimationName);
            playerAnimator.speed = 1f;

            float timer = 0f;
            while (timer < 1f)
            {
                timer += Time.unscaledDeltaTime;
                yield return null;
            }
        }
        else
        {
            Debug.LogError("Player Animator no está asignado.");
        }

        Time.timeScale = 1f;

        SceneManager.LoadScene(2);
    }
}

