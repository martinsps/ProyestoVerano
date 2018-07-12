using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Abilities/FireBullet")]
public class AbilityFireBullet : Ability {
    public GameObject bullet;
    private FireBulletTriggerabe launcher;

    public override void Initialize(GameObject obj)
    {
        launcher = obj.GetComponent<FireBulletTriggerabe>();
        launcher.bullet = bullet;
    }
    public override void TriggerAbility()
    {
        launcher.Fire();
    }
}
