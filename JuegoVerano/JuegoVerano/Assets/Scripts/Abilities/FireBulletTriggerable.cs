using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBulletTriggerable : MonoBehaviour {

    private Transform firePoint;

    [HideInInspector] public GameObject bullet;

	public void Fire()
    {
        firePoint = GameObject.FindObjectOfType<PlayerScript>().gameObject.transform.GetChild(0);
        Instantiate(bullet, firePoint.position, firePoint.rotation);
    }
}
