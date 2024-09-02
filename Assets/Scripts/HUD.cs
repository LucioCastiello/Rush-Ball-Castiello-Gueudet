using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    
    public TextMeshProUGUI puntos;
    public GameObject[] vidas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DesactivarVida(int indice)
    {
        vidas[indice].SetActive(false);
    }
    
}
