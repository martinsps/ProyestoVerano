
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptiosMenu : MonoBehaviour {

    private const string mainMenu = "Menu";

    public Image imageBotonSound;
    public Image imageBotonEfecto;
    private GameManager manager;
    // Use this for initialization
    void Start () {
        Debug.Log("Start");
        manager = FindObjectOfType<GameManager>();
        if (!manager.effectsOn) {
            imageBotonEfecto.enabled = true;
        }

        if (!manager.soundOn)
        {
            imageBotonSound.enabled = true;
        }

        Debug.Log("Fin");


    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void SoundClicked()
    {
        Debug.Log("Cambio sonido");
        manager.ChangeSoundState();
        

    }

    public void EffectClicked()
    {
        Debug.Log("Cambio efecto");
        manager.ChangEffectsState();


    }


 

    public void Return()
    {
        SceneManager.LoadScene(mainMenu);
    }

}
