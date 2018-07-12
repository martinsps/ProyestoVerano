using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBulletTriggerabe : MonoBehaviour {

    public Transform firePoint;

    [HideInInspector] public GameObject bullet;

	public void Fire()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
    }
}
