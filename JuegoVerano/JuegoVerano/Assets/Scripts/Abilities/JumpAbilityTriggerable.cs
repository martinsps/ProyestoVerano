using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAbilityTriggerable : MonoBehaviour {

    private Rigidbody2D player;

    [HideInInspector] public float jumpForce = 1.0f;

    /* void Start()
     {
         player = GameObject.FindObjectOfType<PlayerScript>().GetComponent<Rigidbody2D>();
        o
        player = GetComponent<Rigidbody2D>();
     }*/
    //TODO por que en Start no encuentra al player bien? Es el mismo problema que en el GameManager (y en FireBullet)
    public void Jump()
    {
        player = GameObject.FindObjectOfType<PlayerScript>().GetComponent<Rigidbody2D>();
        player.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
    }
}
