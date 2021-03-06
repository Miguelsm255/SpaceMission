using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_nave : MonoBehaviour
{

    public GameObject bala;
    public GameObject disparo;
    public int puntos = 0;
    public int recordPuntos;
    float velocidad = 2500f;
    float disparar = 0f;

//-----------------------------------------------------------------------------------------------


    void Start()
    {
        transform.position = new Vector3(0,-4,0);
        gameObject.SetActive(true);
        recordPuntos = PlayerPrefs.GetInt("recordPuntos", 0);
    }

//------------------------------------------------------------------------------------------------

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("scripter").GetComponent<general>().puntosEnNave = puntos;
        GameObject.Find("scripter").GetComponent<general>().recordPuntosEnNave = recordPuntos;

        if (puntos > recordPuntos)
            {
                recordPuntos = puntos;
            }

        disparar -= Time.deltaTime;

        if (Input.GetKey(KeyCode.D))
        {
            //transform.Translate(velocidad * Time.deltaTime,0,0);
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(velocidad * Time.deltaTime, 0));
        }

        if (Input.GetKey(KeyCode.A))
        {
            //transform.Translate(-velocidad * Time.deltaTime,0,0);
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-velocidad * Time.deltaTime, 0));
        }

        if (disparar <= 0.5f && Input.GetKey(KeyCode.Space))
        {
            Instantiate(disparo);
            Quaternion rotacion = new Quaternion();    
            Instantiate(bala, new Vector3(transform.position.x + 0.025f,transform.position.y + 0.3f, transform.position.z + 1), rotacion);
            disparar = 1;
        }
    }


    public GameObject gameover;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name == "meteorito(Clone)")
        {
            PlayerPrefs.SetInt("recordPuntos", recordPuntos);

            gameObject.SetActive(false);
            gameover.SetActive(true);
        }
    }
}
