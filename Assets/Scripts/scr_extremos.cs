using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_extremos : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject extremo;

    void Start()
    {
        Quaternion rotacion = new Quaternion();
        Instantiate(extremo,new Vector3(-3,0,0),rotacion);
        Instantiate(extremo,new Vector3(3,0,0),rotacion);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
