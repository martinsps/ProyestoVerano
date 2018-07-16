using UnityEngine;

[CreateAssetMenu(menuName = "Abilities/FireBullet")]
public class AbilityFireBullet : Ability {
    public GameObject bullet;
    private FireBulletTriggerable launcher;

    public override void Initialize(GameObject obj)
    {
        launcher = obj.GetComponent<FireBulletTriggerable>();
        launcher.bullet = bullet;
    }
    public override void TriggerAbility()
    {
        launcher.Fire();
    }
}
