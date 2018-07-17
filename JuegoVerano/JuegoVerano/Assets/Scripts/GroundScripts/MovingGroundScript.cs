using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingGroundScript : MonoBehaviour {

    public Transform firstPosition, secondPosition;
    public float movingSpeed;
    private bool movingToSecond;
   // private Rigidbody2D body;
    public float deltaDistance;
	// Use this for initialization
	void Awake () {
        transform.position = firstPosition.position;
        movingToSecond = true;
   //     body = GetComponent<Rigidbody2D>();
   //     body.velocity = new Vector2(0, 0);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (movingToSecond)
        {
            Vector3 dir = (secondPosition.position - transform.position).normalized;
            //body.velocity = new Vector2(dir.x, dir.y) * movingSpeed;
            transform.position += dir * movingSpeed;
        } else
        {
            Vector3 dir = (firstPosition.position - transform.position).normalized;
            //body.velocity = new Vector2(dir.x, dir.y) * movingSpeed;
            transform.position += dir * movingSpeed;
        }
        if((firstPosition.position - transform.position).magnitude < deltaDistance)
        {
            movingToSecond = true;
        } else if ((secondPosition.position - transform.position).magnitude < deltaDistance)
        {
            movingToSecond = false;
        }
	}
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(CollisionWasWithPlayer(collision))
        {
            collision.gameObject.transform.SetParent(this.transform);
        }
    }

    //SI EN ALGUN MOMENTO EL PLAYER TIENE PADRE ESTO FUERA DE AQUI
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (CollisionWasWithPlayer(collision))
        {
            collision.gameObject.transform.SetParent(null);
        }
    }

    private bool CollisionWasWithPlayer(Collision2D collision)
    {
        return collision.gameObject.CompareTag("Player");
    }
}
