using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectObject : MonoBehaviour
{
    Rigidbody rb;
    public float Items;

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
            gameObject.SetActive(false);
        }
        }

    }

}
