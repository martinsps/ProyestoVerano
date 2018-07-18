using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public abstract class LevelManager : MonoBehaviour {

    public enum GameState
    {
        menu,
        paused,
        inGame
    }

    protected GameState gameState;

    public GameObject player;
    public Canvas ui;

    public Canvas menuGame;
    public Canvas menuPause;

    private const string levelMenu = "Menu";

    // Use this for initialization
    protected void Start()
    {
        Ability[] abilities = FindObjectOfType<GameManager>().abilities;
        AbilityCoolDown[] buttons = ui.GetComponentsInChildren<AbilityCoolDown>();
        if (buttons.Length != abilities.Length)
            Debug.LogError("No están balanceados habilidades y botones");
        for (int i = 0; i < buttons.Length; i++)
        {
            Debug.Log(abilities[i]);
            buttons[i].Initialize(abilities[i], player);
        }
        ChangeGameState(GameState.menu);
    }

    // Update is called once per frame
    protected virtual void Update () {
        if (Input.GetKeyDown(KeyCode.Escape) && gameState == GameState.inGame)
        {
            PauseLevel();
        }
    }

    protected virtual void ChangeGameState(GameState newGameState)
    {
        gameState = newGameState;
        if (newGameState == GameState.inGame)
        {
            menuPause.enabled = false;
            menuGame.enabled = false;
            Time.timeScale = 1f;
            
        }
        else if (newGameState == GameState.paused)
        {
            menuPause.enabled = true;
            Time.timeScale = 0f;
            
        }
        else if (newGameState == GameState.menu)
        {
            Time.timeScale = 0f;
            menuGame.enabled = true;
            menuPause.enabled = false;
        }
    }

    public virtual void StartLevel()
    {
        ChangeGameState(GameState.inGame);
        //COSAS INICIALES
    }

    public virtual void PauseLevel()
    {
        Debug.Log("Se pausa");
        ChangeGameState(GameState.paused);
    }

    public virtual void ResumeLevel()
    {
        ChangeGameState(GameState.inGame);

    }

    public virtual void RestartLevel()
    {
        ChangeGameState(GameState.inGame);
        //FALTA RESTARTEAR EL NIVEL
    }

    public virtual void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(levelMenu);
    }

    public virtual void WinLevel()
    {
        Debug.Log("Ganaste");
    }
}
