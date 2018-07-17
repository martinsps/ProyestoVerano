using UnityEngine;
using UnityEngine.SceneManagement;


public class SelectAbilitiesPanel : MonoBehaviour {

    private const string mainMenu = "Menu";
    private const string TAG = "SelectedAbility";
    private GameManager gameManager;
        


    public void Return(){
        gameManager = FindObjectOfType<GameManager>();
        Debug.Log("EEEEO");
        GameObject[] buttons=GameObject.FindGameObjectsWithTag(TAG);
        Debug.Log("EEEEO2");
        gameManager.abilities=new Ability[buttons.Length];
        for (int i=0; i < buttons.Length; i++)
        {
            Debug.Log("EEEEO3");
            gameManager.abilities[i]=buttons[i].GetComponent<SelectAbility>().selectedAbility;
            Debug.Log(gameManager.abilities[i]);
        }
        Debug.Log("EEEEO4");
        SceneManager.LoadScene(mainMenu);
    }

}
