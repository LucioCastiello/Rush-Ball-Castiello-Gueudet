using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GAMEMANAGER : MonoBehaviour
{
    public float puntos;
    public static GAMEMANAGER Instance { get; private set; }
    public int vidas = 3;

    private void Awake()
    {
        Debug.Log("Awake");
        if (Instance != null && Instance != this)
        {
            Debug.Log("Se destruye");
            Destroy(this.gameObject);
        }
        else
        {
            Debug.Log("Se inicializa");
            Instance = this;
        }
        DontDestroyOnLoad(this);
   
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        
       
    }

  
  
}
