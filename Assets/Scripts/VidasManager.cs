using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VidasManager : MonoBehaviour
{
    int vidas = 1;
    HUD hud; 
    public Animator playerAnimator; 
    public string deathAnimationName; 

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
   
        Time.timeScale = 0f;


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

