using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPausa : MonoBehaviour
{

    [SerializeField] private GameObject botonpausa;
    [SerializeField] private GameObject menupausa;
    public void Pausa()
    {
        Time.timeScale = 0f;
        botonpausa.SetActive(false);
        menupausa.SetActive(true);
    }

    public void Reanudar()
    {
        Time.timeScale = 1f;
        botonpausa.SetActive(true);
        menupausa.SetActive(false);
    }

   
}
