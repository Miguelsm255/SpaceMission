using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class general : MonoBehaviour
{    
    public string escena;
    public int puntosEnNave;
    public int recordPuntosEnNave;

    void Awake()
    {
        Scene scene = SceneManager.GetActiveScene();
        escena = scene.name;
    }

//----------------------------------------------------------------------------------------------------------

    public Text puntuacion;
    public Text recordPuntos;
    public GameObject gameover;
    public GameObject confirmacion;
    public string nombreBoton;

    void Update()
    {
        if (escena == "Game")
        {
            if (GameObject.Find("nave"))
            {
                puntuacion.text = puntosEnNave.ToString("");
            }
            else
            {
                recordPuntos.text = "Record : " + recordPuntosEnNave.ToString();
            }
        }

        if (escena == "Ajustes")
        {
            
        }

        if (escena == "Inicio")
        {

        }
    }

//-------------------------------------------------------------------------------------------------------
    
    //public GameObject gameover;
    public Text version;

    void Start()
    {
        
        if (escena == "Game")
        {
            gameover.SetActive(false);
        }

        if (escena == "Ajustes")
        {
            version.text = "Version: " + Application.version;
            confirmacion.SetActive(false);
        }

        if (escena == "Inicio")
        {
            
        }
        
    }

//-----------------------------------------------------------------------------------------------------------

    public void CerrarJuego()
    {
        Application.Quit();
    }

    public void ChangeScene(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }

    public void BorrarDatos()
    {
        PlayerPrefs.DeleteAll();
    }

//--------------------------------------------------------------------------------------------------

    public void NombreBoton(string boton)
    {
        nombreBoton = boton;
    }

    public void BotonPulsado()
    {
        confirmacion.SetActive(true); 
    }

    public void BotonSi()
    {
        if (nombreBoton == "borrarDatos")
        {
            BorrarDatos();
        }

        confirmacion.SetActive(false);
    }

    public void BotonNo()
    {
        confirmacion.SetActive(false);
    }
}
