using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagement : MonoBehaviour {
    private GameObject player;
    public Canvas ui; 

    void Awake () {
        player = GameObject.FindObjectOfType<PlayerScript>().gameObject;
        Ability[] abilities=player.GetComponent<PlayerScript>().abilities;
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
