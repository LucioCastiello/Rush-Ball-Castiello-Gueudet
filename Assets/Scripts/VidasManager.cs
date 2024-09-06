using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VidasManager : MonoBehaviour
{
    int vidas = 3;
    public HUD hud;

    // Start is called before the first frame update
    void Awake()
    {
        hud = FindObjectOfType<HUD>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PerderVida()
    {
        vidas -= 1;
        if(vidas == 0)
        {
            SceneManager.LoadScene(2);
        }
        hud.DesactivarVida(vidas);
        GAMEMANAGER.Instance.vidas = vidas;
        
    }
}
