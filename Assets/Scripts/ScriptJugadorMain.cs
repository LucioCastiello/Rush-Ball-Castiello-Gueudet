using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptJugadorMain : MonoBehaviour
{
    [Header("Agacharse")]
    [SerializeField] private Transform controladorTecho;
    [SerializeField] private float radioTecho;
    [SerializeField] private float multiplicadorvelocidadagachado;
    [SerializeField] private Collider2D colisionadorAgachado;
    private bool estabaAgachado = false;
    private bool agachar = false;
    public float Velocidad;
    public float Salto;
    private BoxCollider2D boxcollider;
    public LayerMask CapaPasto;
    private Animator animator;
    public SoundManager audioManager;

    // Start is called before the first frame update
    private void Start()
    {
        boxcollider = GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>(); // La clase se llama Animator, no "animator"
    }

    // Update is called once per frame
    private void Update()
    {
        ProcesarMovimiento();
        ProcesarSalto();

    }
    

    void ProcesarMovimiento()
    {
        float inputVelocidad = Input.GetAxis("Horizontal");
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();

        if (inputVelocidad != 0f)
        {
            animator.SetBool("IsRunning", true);
        }
        else
        {
            animator.SetBool("IsRunning", false);
        }

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
