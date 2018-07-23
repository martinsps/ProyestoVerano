using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

    public Ability[] abilities;
    public bool soundOn;
    public bool effectsOn;
    public char primaryHabKey;
    public char secondaryHabKey;

    void Awake()
    {
        //TODO al iniciar la app los valores de los sonido 
        //se deberían ponerse al valor que tomaron la última vez
        soundOn = true;
        effectsOn = true;
        if (instance != null)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void ChangeSoundState()
    {
        soundOn = !soundOn;

    }

    public void ChangEffectsState()
    {
        effectsOn = !effectsOn;

    }

    public void ChangePrimaryHabKey(char habKey)
    {
        primaryHabKey = habKey;
    }

    public void ChangeSecondaryHabKey(char habKey)
    {
        secondaryHabKey = habKey;
    }




}
