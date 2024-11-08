using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public GameObject panelCreditos;
    public GameObject panelTrofeo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivarPanel()
    {
        panelCreditos.SetActive(true);  // Activa el panel
      
    }

    public void ActivarPanelTrofeo()
    {
        panelTrofeo.SetActive(true);
    }

    public void DesactivarPanel()
    {
        panelCreditos.SetActive(false);  // Desactiva el panel
       
    }

    public void DesactivarPanelTrofeo()
    {
        panelTrofeo.SetActive(false);
    }
}
