using UnityEngine;
using UnityEngine.UI;

public class SelectAbility : MonoBehaviour {

    public Ability selectedAbility;

    public Text buttonText;

    public bool showMenu;


	void Start () {
        buttonText.text = selectedAbility.getName();
	}

	void Update () {
        buttonText.text = selectedAbility.getName();
    }

    public void buttonShowMenu()
    {
        showMenu = !showMenu;
    }

    public void selectAbility(Ability newAbility)
    {
        selectedAbility = newAbility;
    }
}
