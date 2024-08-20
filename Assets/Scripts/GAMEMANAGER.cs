using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GAMEMANAGER : MonoBehaviour
{
    private float puntos;
    private TextMeshProUGUI textmesh;
    public GAMEMANAGER hud;
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