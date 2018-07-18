using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;



public class LevelManagerMartin : LevelManager {

    
    public static LevelManagerMartin instance;

    void Awake()
    {
        instance = this;
    }

    protected override void ChangeGameState(GameState newGameState)
    {
        //Parent actions
        base.ChangeGameState(newGameState);
        if (newGameState == GameState.inGame)
        {
            LadronScript.instance.Move();
        }
        else if (newGameState == GameState.paused)
        {
            LadronScript.instance.Stop();
        }
        else if (newGameState == GameState.menu)
        {
            LadronScript.instance.Stop();
        }
    }
}
