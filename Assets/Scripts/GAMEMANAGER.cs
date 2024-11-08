using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAMEMANAGER : MonoBehaviour
{
    public float puntos; // Puntaje actual
    public float mayorPuntaje; // Puntaje máximo registrado
    public int vidas = 3; // Número de vidas
    public static GAMEMANAGER Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            Instance = this;
        }
        DontDestroyOnLoad(this); // No destruir el GameManager al cambiar de escena
    }

    private void Start()
    {
        mayorPuntaje = 0f; // Inicializamos el mayor puntaje al principio
    }

    private void Update()
    {
        // Si el puntaje actual es mayor que el puntaje máximo registrado, lo actualizamos
        if (puntos > mayorPuntaje)
        {
            mayorPuntaje = puntos;
        }
    }

    // Función para reiniciar los puntos y vidas cuando el juego se reinicie
    public void reiniciar()
    {
        puntos = 0; // Reseteamos el puntaje
        vidas = 3; // Reseteamos las vidas
        
    }
}
