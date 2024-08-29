using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptJugadorMain : MonoBehaviour
{
    
    public float Velocidad;
    public float VelocidadAgachado;
    public float Salto;
    private BoxCollider2D boxcollider;
    public LayerMask CapaPasto;
    private Animator animator;
    public bool Agachado = false;
    int agacharID;

    [SerializeField] private AudioClip jumpSound, dieSound;

    // Start is called before the first frame update
    private void Start( )
    {
        boxcollider = GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();
        agacharID = Animator.StringToHash("Agachado");
    }

    // Update is called once per frame
    private void Update()
    {
        ProcesarMovimiento();
        ProcesarSalto();
        Agacharse();

    }
    

    void ProcesarMovimiento()
    {
        float inputVelocidad = Input.GetAxis("Horizontal");
        Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
        float velocidadx;

            if(Agachado)
        {
            velocidadx = Input.GetAxis("Horizontal") * VelocidadAgachado;

        }
        else
        {
            velocidadx = Input.GetAxis("Horizontal") * Velocidad;
        }

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
            0.1f, 
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
            SoundManager.Instance.ReproducirSonido(jumpSound);
        }
    }

   void Agacharse()
    {
       
        {
            if (Input.GetKey(KeyCode.DownArrow))
            {
                Agachado = true;
            }
            else
            {
                Agachado = false;
            }
            animator.SetBool(agacharID, Agachado);
        }
    }
}

