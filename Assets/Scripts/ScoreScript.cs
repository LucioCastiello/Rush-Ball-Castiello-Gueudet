using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public float puntos;

    // Start is called before the first frame update
    void Start()
    {
        puntos = 0;
    }

    // Update is called once per frame
    void Update()
    {
        puntos += 0.5f * Time.deltaTime;
        GAMEMANAGER.Instance.puntos = puntos;
    }
}
