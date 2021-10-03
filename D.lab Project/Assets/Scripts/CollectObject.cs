using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectObject : MonoBehaviour
{
    Rigidbody rb;
    public float Items;
    public Text pickupPrompt; 

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }


    void Update()
    {
        
    }

    void OnTriggerStay(Collider col){
        if(col.gameObject.CompareTag("Collectable")){
        if(Input.GetKeyDown(KeyCode.E)){
            Items ++;
            col.gameObject.SetActive(false);
            pickupPrompt.enabled = false;
        }
        }
    }

    void OnTriggerEnter(Collider col){
    	if(col.gameObject.CompareTag("Collectable")){
    		pickupPrompt.enabled = true;
    	}
    }
    void OnTriggerExit(Collider col){
    	if(col.gameObject.CompareTag("Collectable")){
    		pickupPrompt.enabled = false;
    	}
}
}

    


