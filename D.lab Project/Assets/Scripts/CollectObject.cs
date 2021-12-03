using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectObject : MonoBehaviour
{
    Rigidbody rb;
    public float Items;
    public Text pickupPrompt; 
    private AudioSource ss;
    [SerializeField]
    private AudioClip clip;
    private SphereCollider sphere;

    private float fadeSpeed;
    Renderer fade;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        ss = GetComponent<AudioSource>();
        fade = this.GetComponent<Renderer>();
        sphere = GetComponent<SphereCollider>();

        fadeSpeed = 0.4f;
    }


    void Update()
    {

         }


    void OnTriggerStay(Collider col){
        if(col.gameObject.CompareTag("Player")){
        if(Input.GetKey(KeyCode.E)){
            PlayerScript.Items ++;
            sphere.enabled = !sphere.enabled;
            ss.PlayOneShot(clip, 0.2f);
            pickupPrompt.enabled = false;
            StartCoroutine(FadeOut());
            StartCoroutine(Wait());
        }
        }
    }

    void OnTriggerEnter(Collider col){
    	if(col.gameObject.CompareTag("Player")){
    		pickupPrompt.enabled = true;
    	}
    }
    void OnTriggerExit(Collider col){
    	if(col.gameObject.CompareTag("Player")){
    		pickupPrompt.enabled = false;

    	}
}

    public IEnumerator FadeOut(){
        while(fade.material.color.a>0){
            Color objectColor = fade.material.color;
            float fadeAmount = objectColor.a - (fadeSpeed * Time.deltaTime);

            objectColor = new Color(objectColor.r, objectColor.g, objectColor.b, fadeAmount);
            fade.material.color = objectColor;
            yield return null;
            
        }
    }

    public IEnumerator Wait(){
        yield return new WaitForSeconds(2.4f);
        gameObject.SetActive(false);

        }

}

    


