using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {

    public Button JugarButton;
    public Button PersonajeButton;
    public Button SalirButton;

    private const string LevelJugar = "";
    private const string LevelPersonaje = "";

    // Use this for initialization
    void Start () {
		
	}
	
    void Jugar()
    {
        SceneManager.LoadScene(LevelJugar);
    }

    void Personaje()
    {
        SceneManager.LoadScene(LevelPersonaje);
    }

    void Salir()
    {
        Application.Quit();
    }
	
}
