using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadronScript : MonoBehaviour {

    public static LadronScript instance;

    public Transform[] targets;
    private int currentTarget = 0;
    public float deltaDistance = 0.2f;
    public float movingSpeed = 5f;
    private bool canMove = false;

    private void Awake()
    {
        instance = this;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //Debug.Log("Has ganado la partida");
            LevelManager.instance.WinLevel();
        }
    }

    public void Move()
    {
        canMove = true;
    }

    public void Stop()
    {
        canMove = false;
    }

    private void FixedUpdate()
    {
        if (canMove)
        {
            if (currentTarget >= targets.Length)
            {
                // Debug.Log("El ladron llego antes");
                LevelManager.instance.RestartLevel();
            }
            else
            {
                Vector3 dir = (targets[currentTarget].position - transform.position);
                if (dir.magnitude > deltaDistance)
                {
                    transform.position += dir.normalized * movingSpeed;
                }
                else
                {
                    currentTarget++;
                }
            }
        }
        
        
    }
}
