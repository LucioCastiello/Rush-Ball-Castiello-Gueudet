﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GAMEMANAGER : MonoBehaviour
{
    private float puntos;
    private TextMeshProUGUI textmesh; // Declarar la variable textmesh aquí
    public HUD hud;
    private int vidas = 3;
    public static GAMEMANAGER Instance { get; private set; }

    private void Awake()
    {
        // Implementar el patrón Singleton
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Mantener la instancia si cambias de escena
        }
        else
        {
            Destroy(gameObject); // Destruir instancia duplicada
        }
    }

    private void Start()
    {
        // Asignar el componente TextMeshProUGUI desde el mismo objeto
        textmesh = GetComponent<TextMeshProUGUI>();

        // Verificar si el componente TextMeshProUGUI está asignado
        if (textmesh == null)
        {
            Debug.LogError("TextMeshProUGUI no encontrado en el mismo objeto. Asegúrate de que esté en el mismo objeto que el script.");
        }
    }

    private void Update()
    {
        puntos += Time.deltaTime;

        // Asegurarse de que textmesh no sea nulo antes de usarlo
        if (textmesh != null)
        {
            textmesh.text = puntos.ToString("0");
        }
        else
        {
            Debug.LogError("TextMeshProUGUI es nulo en Update(). Asegúrate de que esté asignado.");
        }
    }

    public void PerderVida()
    {
        vidas -= 1;
        hud.DesactivarVida(vidas);
    }
}
