using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculogenerador : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float generatorTimer = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateObstacle", 0f, generatorTimer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void CreateObstacle()
    {
        Instantiate(obstaclePrefab, transform.position, Quaternion.identity);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el objeto con el que colisiona tiene el tag "Player"
        if (other.CompareTag("Player"))
        {
            // Destruye el objeto del jugador
            Destroy(other.gameObject);
        }
    }
}
