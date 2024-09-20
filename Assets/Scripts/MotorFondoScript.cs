using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotorFondoScript : MonoBehaviour
{
    public float Speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Speed * Time.deltaTime, 0, 0); 
    }
}
