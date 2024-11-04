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
        // Ejecutar la animación de muerte
        playerAnimator.Play(deathAnimationName);

        // Esperar 3 segundos
        yield return new WaitForSeconds(3);

        // Cargar la pantalla de Game Over
        SceneManager.LoadScene(2);
    }
}
