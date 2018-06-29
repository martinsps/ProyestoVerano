using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayerScript : MonoBehaviour {

    bool jump = false;
    public float moveSpeed = 15f;
    public float jumpForce = 15f;

    void Update()
    {
        if (Input.GetKeyDown("w"))
            jump = true;

    }

    private void FixedUpdate()
    {
        if (Input.GetKey("d"))
        {
            Rigidbody2D body = GetComponent<Rigidbody2D>();
            //TODO SI está en el aire que se mueva menos (o agachao, o debuff...) 
            body.velocity = new Vector2(moveSpeed, body.velocity.y);
        }
        if (Input.GetKey("a"))
        {
            Rigidbody2D body = GetComponent<Rigidbody2D>();
            //TODO SI está en el aire que se mueva menos (o agachao, o debuff...)
            body.velocity = new Vector2(-moveSpeed, body.velocity.y);
        }
        if (jump)
        {
            Rigidbody2D body = GetComponent<Rigidbody2D>();
            //TODO Solo si está en el suelo (o si eso doble salto o algo (o una habilidad))
            body.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            jump = false;
        }
        
    }
}
