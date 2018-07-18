using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public GameManager instance;

    public Canvas mainMenu;

    public Ability[] abilities;

    private const string LevelJugar = "Level01";
    //private const string LevelJugar = "LevelMartin";
    private const string LevelPersonaje = "Character";

    void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void Jugar()
    {
        SceneManager.LoadScene(LevelJugar);
    }

    public void Personaje()
    {
        SceneManager.LoadScene(LevelPersonaje);
    }

    public void Salir()
    {
        Debug.Log("Salimos del programa.");
        Application.Quit();
    }
	
}
