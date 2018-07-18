using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadlyGroundScript : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            //KILLPLAYER
            //GameManager.instance.KillPlayer();
            Debug.Log("El player murió");
        }
    }
}
