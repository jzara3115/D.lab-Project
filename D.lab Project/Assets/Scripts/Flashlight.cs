using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    
    public Transform playerface;
    private SphereCollider sc;
    public GameObject Light;

    void Start()
    {
        sc = GetComponent<SphereCollider>();
    }

    void Update()
    {
        
    }

    void OnTriggerStay(Collider col){
    if(col.gameObject.CompareTag("Player")){
    		if(Input.GetKey(KeyCode.E)){
            sc.enabled = !sc.enabled;

            Debug.Log("Flashlight");
        }
    	}
    }

}
