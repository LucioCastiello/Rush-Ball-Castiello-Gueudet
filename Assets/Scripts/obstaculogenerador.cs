using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculogenerador : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float generatorTimer = 2.0f;

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
}
