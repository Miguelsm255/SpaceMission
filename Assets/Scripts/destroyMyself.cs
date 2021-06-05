using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyMyself : MonoBehaviour
{
    public float contador;

    void Start()
    {
        DestroyMyself(contador);
    }

    public void DestroyMyself(float a = 0f)
    {
        Destroy(gameObject, a);
    }
}
