using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagement : MonoBehaviour {
    public GameObject player;
    public Canvas ui; 

    void Start () { 
        Ability[] abilities=FindObjectOfType<GameManager>().abilities;
        AbilityCoolDown[] buttons = ui.GetComponentsInChildren<AbilityCoolDown>();
        if (buttons.Length != abilities.Length)
            Debug.LogError("No están balanceados habilidades y botones");
        for(int i=0; i < buttons.Length; i++)
        {
            Debug.Log(abilities[i]);
            buttons[i].Initialize(abilities[i],player);
        }
	}

}
