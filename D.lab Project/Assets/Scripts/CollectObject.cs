using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectObject : MonoBehaviour
{
    Rigidbody rb;
    public float Items;
    public Text pickupPrompt; 
    float promptTime = 1;

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
        }
        }
    }

    void OnTriggerEnter(Collider col){
    	if(col.gameObject.CompareTag("Collectable")){
    		pickupPrompt.enabled = true;
    	}
    	StartCoroutine("PromptGone");
    }

IEnumerator PromptGone(){
	    yield return new WaitForSeconds(promptTime);
    pickupPrompt.enabled = false;
}

}

    


