using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
    public Vector2 colliderdepiesize;
    public Vector2 colliderdepieoffset;
    public Vector2 crouchSize = new Vector2(1f, 0.5f);
    public Vector2 crouchOffset = new Vector2(0f, -0.25f);
    BoxCollider2D coll;

    [SerializeField] private AudioClip jumpSound, dieSound;

    // Start is called before the first frame update
    private void Start()
    {
        coll = GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();
        agacharID = Animator.StringToHash("Agachado");

        colliderdepiesize = coll.size;
        colliderdepieoffset = coll.offset;

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

        if (Agachado)
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
            coll.bounds.center,
            coll.bounds.size,
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

            animator.SetBool("IsJumping", true);

            Debug.Log("Personaje está saltando");
        }
        if (EstaEnSuelo())

        { 

        
            Debug.Log("Personaje está en el suelo");
        } 
    }

    void Agacharse()
    {

        {
            if (Input.GetKey(KeyCode.DownArrow))
            {
                Agachado = true;
                Crouch();
            }
            else
            {
                Agachado = false;
                StandUp();

            }
            animator.SetBool(agacharID, Agachado);
        }
    }

    void Crouch()
    {
        coll.size = crouchSize;
        coll.offset = crouchOffset;
    }

    void StandUp()
    {
        coll.size = colliderdepiesize;
        coll.offset = colliderdepieoffset;
    }



    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "destructor")
        {
            Destroy(gameObject);
            SceneManager.LoadScene(2);

        }

        if (other.CompareTag("Defender") || other.CompareTag("Botella"))
        {

            animator.SetTrigger("Colissiona");
            Debug.Log("Colisión detectada con: " + other.gameObject.name);

        }

    }


}