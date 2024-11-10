using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    
    public float puntosBase;

    
    void Start()
    {
        GAMEMANAGER.Instance.puntos = 0;
        puntosBase = 0;
    }

    
    void Update()
    {
        
        puntosBase += 0.5f * Time.deltaTime;

       if (puntosBase > GAMEMANAGER.Instance.puntos)
        {
            GAMEMANAGER.Instance.puntos = puntosBase;
        }
    }
}
