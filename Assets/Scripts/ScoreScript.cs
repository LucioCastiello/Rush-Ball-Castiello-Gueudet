using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreScript : MonoBehaviour
{
    // Se mantendrá un puntaje base que será actualizado en el GameManager
    public float puntosBase;

    // Start is called before the first frame update
    void Start()
    {
        GAMEMANAGER.Instance.puntos = 0;
        puntosBase = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // Incrementamos los puntos
        puntosBase += 0.5f * Time.deltaTime;

        // Actualizamos el puntaje en el GameManager solo si es mayor que el anterior
        if (puntosBase > GAMEMANAGER.Instance.puntos)
        {
            GAMEMANAGER.Instance.puntos = puntosBase;
        }
    }
}
