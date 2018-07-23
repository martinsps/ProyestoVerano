using UnityEngine;
using UnityEngine.UI;

public class AbilityButton : MonoBehaviour {

    private Text buttonText;

    public Ability ability;

    private Animator buttonAnimator;

    private SelectAbility parentButton;

    private const string boolVar = "b_show";


    // Use this for initialization
    void Start () {
        buttonText = GetComponentInChildren<Text>(); 
        buttonText.text = ability.getName();
        buttonAnimator = GetComponent<Animator>();
        parentButton = GetComponentInParent<SelectAbility>();
    }

    // Update is called once per frame
    void Update()
    {
        buttonAnimator.SetBool(boolVar, parentButton.showMenu);
    }

    public void buttonPressed()
    {
        parentButton.showMenu = false;
        parentButton.selectAbility(ability);
    } 

}
