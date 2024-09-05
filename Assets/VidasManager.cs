using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        hud.DesactivarVida(vidas);
        GAMEMANAGER.Instance.vidas = vidas;
        
    }
}
