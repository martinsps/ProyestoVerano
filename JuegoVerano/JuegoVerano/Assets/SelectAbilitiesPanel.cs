using UnityEngine;
using UnityEngine.SceneManagement;


public class SelectAbilitiesPanel : MonoBehaviour {

    private const string mainMenu = "Menu";
    private const string TAG = "SelectedAbility";
    private PlayerScript player;


    public void Return(){
        player = FindObjectOfType<PlayerScript>();
        Debug.Log("EEEEO");
        GameObject[] buttons=GameObject.FindGameObjectsWithTag(TAG);
        Debug.Log("EEEEO2");
        player.abilities=new Ability[buttons.Length];
        for (int i=0; i < buttons.Length; i++)
        {
            Debug.Log("EEEEO3");
            player.abilities[i]=buttons[i].GetComponent<SelectAbility>().selectedAbility;
            Debug.Log(player.abilities[i]);
        }
        Debug.Log("EEEEO4");
        SceneManager.LoadScene(mainMenu);
    }

}
