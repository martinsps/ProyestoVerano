using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayerScript : MonoBehaviour {

    bool jump = false;
    public float moveSpeed = 15f;
    public float jumpForce = 15f;
    public LayerMask groundLayerMask;
    private Rigidbody2D body;


    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown("w"))
            jump = true;

    }

    private void FixedUpdate()
    {
        if (isOnTheFloor())body.velocity = new Vector2(0, body.velocity.y);
        if (Input.GetKey("d"))
        {
            //TODO SI está en el aire que se mueva menos (o agachao, o debuff...) 
            body.velocity = new Vector2(moveSpeed, body.velocity.y);
        }
        if (Input.GetKey("a"))
        {
            //TODO SI está en el aire que se mueva menos (o agachao, o debuff...)
            body.velocity = new Vector2(-moveSpeed, body.velocity.y);
        }
        if (jump)
        {
            if (isOnTheFloor())
            {
                //TODO Solo si está en el suelo (o si eso doble salto o algo (o una habilidad))
                body.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            }
            jump = false;
        }        
    }

    private bool isOnTheFloor()
    {
        return Physics2D.Raycast(this.transform.position, Vector2.down, 0.8f, groundLayerMask.value);
    }
}
