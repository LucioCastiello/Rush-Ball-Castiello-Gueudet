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

    }

    // Update is called once per frame
    void Update()
    {
        Puntaje = GAMEMANAGER.Instance.puntos;
        TxtPuntaje.text = Puntaje.ToString("F1");

        Debug.Log(TxtPuntaje.text);
    }
}
