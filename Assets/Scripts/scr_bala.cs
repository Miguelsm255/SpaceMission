using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class scr_bala : MonoBehaviour
{
    public float velocidad = 10;

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

    void OnTriggerEnter2D(Collider2D col)
    {
        if (GameObject.Find("meteorito(Clone)"))
        {
            bool golpeado = GameObject.Find("meteorito(Clone)").GetComponent<Animator>().GetBool("golpeado");
        
            if (golpeado == false && col.gameObject.name == "meteorito(Clone)")
            {
                Destroy(gameObject);
            }
        }
        
    }
}
