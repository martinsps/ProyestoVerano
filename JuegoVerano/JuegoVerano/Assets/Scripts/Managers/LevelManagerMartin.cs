using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public enum GameState
{
    menu,
    paused,
    inGame
}

public class LevelManager : MonoBehaviour {

    private GameState gameState;

    public static LevelManager instance;

    public Canvas menuGame;
    public Canvas menuPause;

    private const string levelMenu = "Menu";
	
	// Update is called once per frame
	void Awake () {
        instance = this;
    }

    private void Start()
    {
        ChangeGameState(GameState.menu);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)&&gameState == GameState.inGame)
        {
            PauseLevel();
        }
    }

    public void StartLevel()
    {
        ChangeGameState(GameState.inGame);
        //COSAS INICIALES
    }

    public void PauseLevel()
    {
        ChangeGameState(GameState.paused);
    }

    public void ResumeLevel()
    {
        ChangeGameState(GameState.inGame);
        
    }

    public void RestartLevel()
    {
        ChangeGameState(GameState.inGame);
        //FALTA RESTARTEAR EL NIVEL
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(levelMenu);
    }

    public void WinLevel()
    {
        Debug.Log("Ganaste");
    }

    private void ChangeGameState(GameState newGameState)
    {
        gameState = newGameState;
        if (newGameState == GameState.inGame)
        {
            menuPause.enabled = false;
            menuGame.enabled = false;
            Time.timeScale = 1f;
            //ESPECIFICO DEL NIVEL
            LadronScript.instance.Move();
        } else if(newGameState == GameState.paused)
        {
            menuPause.enabled = true;
            Time.timeScale = 0f;
            //ESPECIFICO DEL NIVEL
            LadronScript.instance.Stop();
        } else if (newGameState == GameState.menu)
        {
            Time.timeScale = 0f;
            menuGame.enabled = true;
            menuPause.enabled = false;
            //ESPECIFICO DEL NIVEL
            LadronScript.instance.Stop();
        }
    }

}
