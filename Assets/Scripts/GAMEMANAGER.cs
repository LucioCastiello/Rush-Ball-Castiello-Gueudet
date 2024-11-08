using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAMEMANAGER : MonoBehaviour
{
    public float puntos; 
    public float mayorPuntaje; 
    public int vidas = 3; 
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
        DontDestroyOnLoad(this); 
    }

    private void Start()
    {
        mayorPuntaje = 0f;
        Time.timeScale = 1f;
    }

    private void Update()
    {
        
        if (puntos > mayorPuntaje)
        {
            mayorPuntaje = puntos;
        }
    }

    
    public void reiniciar()
    {
        puntos = 0; 
        vidas = 3; 
        
    }
}
