using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculogenerador : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float generatorTimer = 10.0f;

    
    void Start()
    {
        InvokeRepeating("CreateObstacle", 1f, generatorTimer);
    }

    
    void Update()
    {
        
    }
    void CreateObstacle()
    {
        Instantiate(obstaclePrefab, transform.position, Quaternion.identity);
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
           
            Destroy(other.gameObject);
        }
    }
}
