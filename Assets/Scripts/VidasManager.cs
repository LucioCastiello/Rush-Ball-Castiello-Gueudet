using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VidasManager : MonoBehaviour
{
    int vidas = 1;
    HUD hud; // Referencia al HUD
    public Animator playerAnimator; // Referencia al Animador del jugador
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
        // Pausar todo el juego, pero mantener las animaciones
        Time.timeScale = 0f;

        // Si tenemos un Animador, ejecutamos la animación de muerte
        if (playerAnimator != null)
        {
            // Aseguramos que la animación de muerte se ejecute
            playerAnimator.Play(deathAnimationName);

            // Restauramos la velocidad del Animator, para que la animación siga corriendo a pesar de que Time.timeScale está en 0
            playerAnimator.speed = 1f;

            // Esperamos 3 segundos, sin que la escala de tiempo afecte
            float timer = 0f;
            while (timer < 1f)
            {
                timer += Time.unscaledDeltaTime; // Usamos Time.unscaledDeltaTime para que el temporizador siga en tiempo real
                yield return null;
            }
        }
        else
        {
            Debug.LogError("Player Animator no está asignado.");
        }

        // Restauramos la escala de tiempo a su valor normal
        Time.timeScale = 1f;

        // Cargar la escena de Game Over
        SceneManager.LoadScene(2);
    }
}

