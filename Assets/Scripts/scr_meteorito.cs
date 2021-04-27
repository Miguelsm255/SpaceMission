using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_meteorito : MonoBehaviour
{
    float velocidad = -4;

//-------------------------------------------------------------------------------------------------------

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,4f);
    }

//------------------------------------------------------------------------------------------------------------

    // Update is called once per frame
    void Update()
    {   
        transform.Translate(0,1 * velocidad * Time.deltaTime ,0);
    }

//--------------------------------------------------------------------------------------------------------------

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "bala(Clone)")
        {
            Destroy(gameObject);
        }
    }
}
