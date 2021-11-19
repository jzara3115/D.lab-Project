using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    private Rigidbody rb;
    public Vector3 respawn;
    public bool isDead = false;

    
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    
    void Update()
    {

    }

    void OnTriggerEnter(Collider col){
        if(col.gameObject.CompareTag("Death")){
            transform.position = respawn;
    		isDead = true;
            Physics.SyncTransforms();
    	}
    }

}
