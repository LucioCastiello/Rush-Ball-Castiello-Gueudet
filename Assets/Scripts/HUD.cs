using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    
    public TextMeshProUGUI puntos;
    public GameObject[] vidas;

   
    // Update is called once per frame
    void Update()
    {
        puntos.text = Mathf.Ceil(GAMEMANAGER.Instance.puntos).ToString();
    }

    
    
}
