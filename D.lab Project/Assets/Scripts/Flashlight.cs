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
    private AudioSource ss;
    public AudioClip clip;
    public AudioClip turning;

    void Start()
    {
        sc = GetComponent<SphereCollider>();
        ss = GetComponent<AudioSource>();

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)&&collected == true){
            if(on){
                Light.SetActive(false);
                on = false;
                ss.PlayOneShot(turning, 0.5f);
            } else{
                Light.SetActive(true);
                on = true;   
                ss.PlayOneShot(turning, 0.5f);
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
            ss.PlayOneShot(clip, 0.5f);
            Debug.Log("Flashlight");
        }
    	}
    }


}
