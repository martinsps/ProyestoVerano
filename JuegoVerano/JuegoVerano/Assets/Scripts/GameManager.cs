using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public Canvas mainMenu;

    private const string LevelJugar = "Level01";
    private const string LevelPersonaje = "Character";

    // Use this for initialization
    void Awake () {
        mainMenu.enabled = true;
	}
	
    public void Jugar()
    {
       GameObject player = GameObject.FindObjectOfType<PlayerScript>().gameObject;
        for(int i=0; i< player.GetComponent<PlayerScript>().abilities.Length;i++)
            Debug.Log(player.GetComponent<PlayerScript>().abilities[i]);
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
