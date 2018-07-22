using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenuManager : MonoBehaviour {

    public Canvas mainMenu;

    private const string LevelJugar = "Level01";
    //private const string LevelJugar = "LevelMartin";
    private const string LevelPersonaje = "Character";
    private const string MenuOpciones = "Options";

    public void Jugar()
    {
        SceneManager.LoadScene(LevelJugar);
    }

    public void Personaje()
    {
        SceneManager.LoadScene(LevelPersonaje);
    }

    public void Opciones()
    {
        SceneManager.LoadScene(MenuOpciones);
    }

    public void Salir()
    {
        Debug.Log("Salimos del programa.");
        Application.Quit();
    }

}
