 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UiPuntosWinkel : MonoBehaviour
{
    public TextMeshProUGUI txt_tusPuntos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txt_tusPuntos.text = GAMEMANAGER.Instance.puntos.ToString("F1"); 
    }
}
