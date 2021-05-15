using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteoritoSpawner : MonoBehaviour
{
    public float timer = 3;
    public GameObject meteorito;
    public float esperaPrincipio = 5;

//-------------------------------------------------------------------------------------------------

    // Start is called before the first frame update
    void Start()
    {
        timer += esperaPrincipio;
    }

//------------------------------------------------------------------------------------------------

    // Update is called once per frame
    void Update()
    {
        
        timer -= Time.deltaTime;

        if (timer < 0)
        {
            timer = 1f;
            Quaternion rotacion = new Quaternion();
            float x = Random.Range(-2.0f , 2.0f);
            Instantiate(meteorito , new Vector3(x , 6f , 0f) , rotacion);
        }
    }
}
