using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Flashlight : MonoBehaviour
{
    
    public GameObject playerface;
    private SphereCollider sc;
    public bool collected = false;
    public bool on = true;
    private AudioSource ss;
    public AudioClip clip;
    public AudioClip turning;

    public Material reveal;
    public Material reveal2;
    public Material reveal3;
    public Material reveal4;
    public Light m_light;
    private float OGrange;

    void Start()
    {
        sc = GetComponent<SphereCollider>();
        ss = GetComponent<AudioSource>();
        OGrange = m_light.range;
    }

    void Update()
    {

            reveal.SetVector("_LightPosition", m_light.transform.position);
            reveal.SetVector("_LightDirection", -m_light.transform.forward);
            reveal.SetFloat("_LightAngle", m_light.spotAngle);
            reveal.SetFloat("_LightRange", m_light.range);

            reveal2.SetVector("_LightPosition", m_light.transform.position);
            reveal2.SetVector("_LightDirection", -m_light.transform.forward);
            reveal2.SetFloat("_LightAngle", m_light.spotAngle);
            reveal2.SetFloat("_LightRange", m_light.range);

            reveal3.SetVector("_LightPosition", m_light.transform.position);
            reveal3.SetVector("_LightDirection", -m_light.transform.forward);
            reveal3.SetFloat("_LightAngle", m_light.spotAngle);
            reveal3.SetFloat("_LightRange", m_light.range);

            reveal4.SetVector("_LightPosition", m_light.transform.position);
            reveal4.SetVector("_LightDirection", -m_light.transform.forward);
            reveal4.SetFloat("_LightAngle", m_light.spotAngle);
            reveal4.SetFloat("_LightRange", m_light.range);


        if (Input.GetKeyDown(KeyCode.Mouse0)&&collected == true){
            if(on){
                m_light.enabled = false;
                m_light.range = 0f;
                on = false;
                ss.PlayOneShot(turning, 0.5f);
            } else{
                m_light.enabled = true;
                m_light.range = OGrange;
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
