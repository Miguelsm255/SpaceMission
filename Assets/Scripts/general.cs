using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class general : MonoBehaviour
{
    public void ChangeScene(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }

//---------------------------------------------------------------------------------------------------------

    public Text puntuacion;

    void Update()
    {
        puntuacion.text = GameObject.Find("nave").GetComponent<scr_nave>().puntos.ToString("");
    }

//-------------------------------------------------------------------------------------------------------
    public GameObject gameover;
    void Start()
    {
        gameover.SetActive(false);
    }

}