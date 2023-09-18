using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    float velocidadecarro;
    void Start()
    {
        velocidadecarro = 20;
    }

    
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.Translate(0, 0, (velocidadecarro * Time.deltaTime));
        }

        if (Input.GetKey("s"))
        {
            transform.Translate(0, 0, (-velocidadecarro * Time.deltaTime));
        }
    }
}
