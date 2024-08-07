using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguimientoCamara : MonoBehaviour
{
    public Transform personaje;

    private float tamañocamara;
    private float alturapantalla;
    public float seguimientoX;
    public GameObject jugadorMain;
    // Start is called before the first frame update
    void Start()
    {
        tamañocamara = Camera.main.orthographicSize;
        alturapantalla = tamañocamara * 2;
        
    }

    // Update is called once per frame
    void Update()
    {
        CalcularPosicionCamera();
        seguimientoX = jugadorMain.transform.position.x;
    }

    void CalcularPosicionCamera()
    {
        int pantallaPersonaje = (int)(personaje.position.x / alturapantalla);
        float alturaCamara = (pantallaPersonaje * alturapantalla) + tamañocamara;

        transform.position = new Vector3(seguimientoX, transform.position.y, transform.position.z);
    }
}
