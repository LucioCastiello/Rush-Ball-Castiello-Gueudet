using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PuntajeScript : MonoBehaviour
{
    private float puntos;
    private TextMeshProUGUI textmesh;

    private void Start()
    {
        textmesh = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        puntos += Time.deltaTime;
        textmesh.text = puntos.ToString("0"); 
    }
}