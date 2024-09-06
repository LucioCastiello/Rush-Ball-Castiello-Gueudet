using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScriptUI : MonoBehaviour
{
    public Text TxtPuntaje;
    public float Puntaje;

    // Start is called before the first frame update
    void Start()
    {
       Puntaje = PlayerPrefs.GetFloat("puntos");
       TxtPuntaje.text = Puntaje.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
