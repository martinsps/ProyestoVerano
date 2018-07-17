using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpAbilityTriggerable : MonoBehaviour {

    private Rigidbody2D player;

    [HideInInspector] public float jumpForce = 1.0f;

    void Start()
    {
        player=GetComponent<Rigidbody2D>();
    }

    public void Jump()
    {
        player.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
    }
}
