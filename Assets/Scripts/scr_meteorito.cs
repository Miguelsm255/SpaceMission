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
        if (gameObject.GetComponent<Animator>().GetBool("golpeado") == false)
        {
            transform.Translate(0,1 * velocidad * Time.deltaTime ,0);
        }

        if (gameObject.GetComponent<SpriteRenderer>().sprite.name == "vacio")
        {
            Destroy(gameObject);
        }
    }

//--------------------------------------------------------------------------------------------------------------

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "bala(Clone)" || col.gameObject.name =="nave")
        {
            gameObject.GetComponent<Animator>().SetBool("golpeado",true);
        }
    }
}
