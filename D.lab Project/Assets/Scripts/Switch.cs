using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public List<GameObject> ObjectsToDestroy;
    private int currentActiveIndex = 0;
    private bool on = false;
    private AudioSource ss;
    [SerializeField]
    private AudioClip clip;
    [SerializeField]
    private float vol;


    void Awake(){
        ss = GetComponent<AudioSource>();
    }

    void Update(){
        if (on==true){
        ObjectsToDestroy[currentActiveIndex].SetActive(false);
        currentActiveIndex++;
    if (currentActiveIndex >= ObjectsToDestroy.Count)
        currentActiveIndex = 0;
        }
    }

    void OnTriggerStay(Collider col){
        if(col.gameObject.CompareTag("Player") && on == false){
        if(Input.GetKey(KeyCode.E)){
        on = true;
        ss.PlayOneShot(clip, vol);
    }
    }
    }


}

