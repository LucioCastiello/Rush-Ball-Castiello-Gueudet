using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptJugadorMain : MonoBehaviour
{
    public float Velocidad;
    public float Salto;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        ProcesarMovimiento();
        ProcesarSalto();
    }

    void ProcesarMovimiento()
    {
        float inputVelocidad = Input.GetAxis("Horizontal");
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();

        rigidbody.velocity = new Vector2(inputVelocidad * Velocidad, rigidbody.velocity.y);
    }

    void ProcesarSalto()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
            rigidbody.AddForce(Vector2.up * Salto, ForceMode2D.Impulse);
        }
    }
}
