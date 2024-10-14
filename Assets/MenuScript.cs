using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    public GameObject panel;
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
        panel.SetActive(true);  // Activa el panel
    }

    public void DesactivarPanel()
    {
        panel.SetActive(false);  // Desactiva el panel
    }
}
