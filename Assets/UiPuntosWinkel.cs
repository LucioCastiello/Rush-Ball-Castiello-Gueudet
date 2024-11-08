using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UiPuntosWinkel : MonoBehaviour
{
    public TextMeshProUGUI txt_tusPuntos; // Texto para el puntaje actual
    public TextMeshProUGUI txt_mayorPuntaje; // Texto para el mayor puntaje

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Actualizamos ambos textos, el puntaje actual y el mayor puntaje
        txt_tusPuntos.text =  GAMEMANAGER.Instance.puntos.ToString("F1");
        txt_mayorPuntaje.text = GAMEMANAGER.Instance.mayorPuntaje.ToString("F1");
    }
}
