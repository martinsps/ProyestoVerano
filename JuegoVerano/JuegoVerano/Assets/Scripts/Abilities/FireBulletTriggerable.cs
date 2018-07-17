using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBulletTriggerable : MonoBehaviour {

    private Transform firePoint;

    [HideInInspector] public GameObject bullet;

    void Start()
    {
        firePoint = transform.GetChild(0);
    }


    public void Fire()
    {
        Instantiate(bullet, firePoint.position, firePoint.rotation);
    }
}
