using UnityEngine;

[CreateAssetMenu(menuName = "Abilities/AbilityJump")]
public class AbilityJump : Ability
{
    public float jumpForce = 10.0f;
    private JumpAbilityTriggerable launcher;

    public override void Initialize(GameObject obj)
    {
        launcher = obj.GetComponent<JumpAbilityTriggerable>();
        launcher.jumpForce= jumpForce;
    }
    public override void TriggerAbility()
    {
        launcher.Jump();
    }
}
