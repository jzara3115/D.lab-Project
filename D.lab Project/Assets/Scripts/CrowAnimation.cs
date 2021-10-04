using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowAnimation : MonoBehaviour
{
    Animator crowAnimation;
    void Start()
    {
        crowAnimation = this.transform.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col){
        crowAnimation.SetTrigger("Flying");
    }
}
