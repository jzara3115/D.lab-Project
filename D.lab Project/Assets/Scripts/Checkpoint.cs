using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
 
    Vector3 respawn;
    Respawn respawnScript;

    void Start()
    {
        respawnScript = GameObject.FindObjectOfType<Respawn>();
    }

    void OnTriggerEnter(Collider col){
        if(col.gameObject.CompareTag("Player")){
    		respawnScript.respawn = transform.position ;
            
    	}
    }
}
