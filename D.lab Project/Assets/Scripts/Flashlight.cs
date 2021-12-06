using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    
    public GameObject playerface;
    private SphereCollider sc;
    public GameObject Light;
    public bool collected = false;
    public bool on = true;

    void Start()
    {
        sc = GetComponent<SphereCollider>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)&&collected == true){
            if(on){
                Light.SetActive(false);
                on = false;
            } else{
                Light.SetActive(true);
                on = true;
            }
    }

}

    void OnTriggerStay(Collider col){
    if(col.gameObject.CompareTag("Player")){
    		if(Input.GetKey(KeyCode.E)){
            sc.enabled = !sc.enabled;
            collected = true;
            gameObject.transform.parent = playerface.transform;
            gameObject.transform.position = playerface.transform.position;
            gameObject.transform.rotation = playerface.transform.rotation;
            Debug.Log("Flashlight");
        }
    	}
    }


}
