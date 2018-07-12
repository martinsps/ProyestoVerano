using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    public Ability[] abilities;

    public static PlayerScript instance;

    //Singleton and for using it in other scenes
    void Awake () {
        if (instance != null)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
	}
	

}
