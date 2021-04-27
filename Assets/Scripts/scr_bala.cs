using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_bala : MonoBehaviour
{
    float velocidad = 10;
//---------------------------------------------------------------------------------------------

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,5f);
    }

//--------------------------------------------------------------------------------------------

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0 , velocidad * Time.deltaTime , 1);
    }

//----------------------------------------------------------------------------------------------

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "meteorito(Clone)")
        {
            Destroy(gameObject);           
        }
    }
}
