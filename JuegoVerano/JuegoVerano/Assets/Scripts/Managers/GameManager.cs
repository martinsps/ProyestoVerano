using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance;

	// Use this for initialization
	void Awake () {
        if(instance != null)
            Destroy(gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }

    }

    public void KillPlayer()
    {
        //PlayerScript.instance.KillPlayer();
        //MAS COSAS
    }

    // Update is called once per frame
    void Update () {
		
	}
}
