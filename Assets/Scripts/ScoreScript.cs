using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    public float puntosBase;

    // Start is called before the first frame update
    void Start()
    {
        puntosBase = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // Incrementamos los puntos base
        puntosBase += 0.5f * Time.deltaTime;

        // Actualizamos el puntaje en el GameManager si es mayor que el puntaje actual
        if (puntosBase > GAMEMANAGER.Instance.puntos)
        {
            GAMEMANAGER.Instance.puntos = puntosBase;
        }
    }
}
