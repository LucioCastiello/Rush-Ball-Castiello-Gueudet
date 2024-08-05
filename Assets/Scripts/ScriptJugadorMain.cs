
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptJugadorMain : MonoBehaviour
{
    public float Velocidad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcesarMovimiento();
    }

    void ProcesarMovimiento()
    {

        float inputVelocidad = Input.GetAxis("Horizontal");
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();

        rigidbody.velocity = new Vector2(inputVelocidad * Velocidad, rigidbody.velocity.y);
    }

    void ProcesarSalto()
    {

    }
}
