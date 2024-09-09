using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotellaScript : MonoBehaviour
{
    public float velocidad = 4f;

    private Rigidbody2D rigid2d;

    public VidasManager vidasMgr;

    private Animator animator;
    private bool isCollided = false;

    private void Awake()
    {
        vidasMgr = FindObjectOfType<VidasManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        rigid2d = GetComponent<Rigidbody2D>();
        rigid2d.velocity = Vector2.left * velocidad;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

   

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            vidasMgr.PerderVida();
            isCollided = true;
            animator.SetTrigger("Collide");

        }
    }
    public void DestroyBottle()
    {
        Destroy(gameObject);
    }
}
