using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class general : MonoBehaviour
{    
    string escena;

    void Awake()
    {
        Scene scene = SceneManager.GetActiveScene();
        escena = scene.name;
    }

//----------------------------------------------------------------------------------------------------------

    public Text puntuacion;

    void Update()
    {
        if (escena == "Game")
        {
            if (GameObject.Find("nave"))
            {
                puntuacion.text = GameObject.Find("nave").GetComponent<scr_nave>().puntos.ToString("");
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
    
    public GameObject gameover;
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

}
