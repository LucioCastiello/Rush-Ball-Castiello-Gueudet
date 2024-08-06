using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptJugadorMain : MonoBehaviour
{
    public float Velocidad;
    public float Salto;
    private BoxCollider2D boxcollider;
    public LayerMask CapaPasto;

    // Start is called before the first frame update
    void Start()
    {
        boxcollider = GetComponent<BoxCollider2D>();
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

    bool EstaEnSuelo()
    {
        RaycastHit2D hit = Physics2D.BoxCast(
            boxcollider.bounds.center,
            boxcollider.bounds.size,
            0f,
            Vector2.down,
            0.1f, // Distancia del BoxCast, ajusta según sea necesario
            CapaPasto
        );

        return hit.collider != null;
    }

    void ProcesarSalto()
    {
        if (Input.GetKeyDown(KeyCode.Space) && EstaEnSuelo())
        {
            Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
            rigidbody.AddForce(Vector2.up * Salto, ForceMode2D.Impulse);
        }
    }
}
