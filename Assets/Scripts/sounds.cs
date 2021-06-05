using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sounds : MonoBehaviour
{
    public GameObject sonido;
    public float duracion;
    float contador;
    public bool efectoSonoro;

    void Start()
    {
        contador = duracion;
    }

    void Update()
    {
        contador += Time.deltaTime;

        if (contador > duracion)
        {
            contador = 0f;

            if (efectoSonoro == false)
            {
                Instantiate(sonido);
            }
        }
    }
}
