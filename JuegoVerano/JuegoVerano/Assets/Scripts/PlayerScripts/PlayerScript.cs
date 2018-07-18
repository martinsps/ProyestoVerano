using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    public Ability[] abilities;

    public static PlayerScript instance;

    //Health points of the player
    public int healthPoints = 100;

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

    public void Damage(int dmg)
    {
        if(healthPoints - dmg <= 0)
        {
            healthPoints = 0;
            Kill();
        }
        else
        {
            healthPoints -= dmg;
        }
    }

    public void Kill()
    {
        Debug.Log("Player has been killed");
    }




}
