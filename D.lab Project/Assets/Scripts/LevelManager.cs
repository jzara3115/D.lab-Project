using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public Animator anim;

    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col){
    	if(col.gameObject.CompareTag("Player")){
    		anim.SetTrigger("Fade Out");
    	}
    }

    public void OnFadeComplete(){
        SceneManager.LoadScene("WaterScene");
    }
}
