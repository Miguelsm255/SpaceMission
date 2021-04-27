using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlNave : MonoBehaviour
{

    float velocidad = 2500f;
    public GameObject bala;
    float disparar = 0;

//-----------------------------------------------------------------------------------------------

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0,-4,0);
    }

//------------------------------------------------------------------------------------------------

    // Update is called once per frame
    void Update()
    {
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

        if (disparar <= 0.5 && Input.GetKey(KeyCode.Space))
        {
            Quaternion rotacion = new Quaternion();    
            Instantiate(bala, new Vector3(transform.position.x + 0.025f,transform.position.y + 0.3f, transform.position.z + 1), rotacion);
            disparar = 1;
        }
    }
}
