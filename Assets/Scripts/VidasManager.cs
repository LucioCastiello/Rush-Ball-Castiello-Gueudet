using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VidasManager : MonoBehaviour
{
    int vidas = 1;
    public HUD hud;
    public Animator playerAnimator; // Referencia al Animator del jugador
    public string deathAnimationName; // Nombre de la animación de muerte

    void Awake()
    {
        hud = FindObjectOfType<HUD>();
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
        // Pausar el juego
        Time.timeScale = 0f;

        if (playerAnimator != null)
        {
            // Ejecutar la animación de muerte
            playerAnimator.Play(deathAnimationName);

            // Esperar 3 segundos en tiempo no escalado
            float timer = 0f;
            while (timer < 3f)
            {
                timer += Time.unscaledDeltaTime;
                yield return null;
            }
        }
        else
        {
            Debug.LogError("Player Animator no está asignado.");
        }

        // Restaurar la escala de tiempo
        Time.timeScale = 1f;

        // Cargar la pantalla de Game Over
        SceneManager.LoadScene(2);
    }

}
