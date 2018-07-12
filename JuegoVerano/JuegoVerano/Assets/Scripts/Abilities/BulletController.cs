using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {
    public float speed = 1f;

    private PlayerScript player;

    private Rigidbody2D body;



    // Use this for initialization
    void Start () {
        body = GetComponent<Rigidbody2D>();
        player = FindObjectOfType<PlayerScript>();
        if (player.transform.localScale.x < 0)
            speed = -speed;
        body.velocity = new Vector2(speed, body.velocity.y);
    }
	
	// Update is called once per frame
	void Update () {
        body.velocity = new Vector2(speed, body.velocity.y);
	}

    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
    }
}
