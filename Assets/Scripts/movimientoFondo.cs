using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoFondo : MonoBehaviour
{
    public float velocidad;

//-----------------------------------------------------------------------------------------------

    // Start is called before the first frame update
    void Start()
    {
        
    }

//------------------------------------------------------------------------------------------------

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,-velocidad * Time.deltaTime, 0);

        if (transform.position.y <= -15)
        {
            transform.position = new Vector3(0,10,0);
        }
    }
}