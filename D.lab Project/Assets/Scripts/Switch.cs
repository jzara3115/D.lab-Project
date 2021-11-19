using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public List<GameObject> ObjectsToDestroy;
    private int currentActiveIndex = 0;

    void OnTriggerStay(Collider col){
        if(col.gameObject.CompareTag("Player")){
        if(Input.GetKey(KeyCode.E)){
        ObjectsToDestroy[currentActiveIndex].SetActive(false);
        currentActiveIndex++;
    if (currentActiveIndex >= ObjectsToDestroy.Count)
        currentActiveIndex = 0;
        }
        }
    }

}

