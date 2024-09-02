using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controladorobstaculo : MonoBehaviour

    
{

    public float velocidad = 4f;

    private Rigidbody2D rigid2d;



    // Start is called before the first frame update
    void Start()
    {
        rigid2d = GetComponent<Rigidbody2D>();
        rigid2d.velocity = Vector2.left * velocidad;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "destructor")
        {
            Destroy(gameObject);
        }
       
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        { 
            GAMEMANAGER.Instance.PerderVida();
        }
    }
}
