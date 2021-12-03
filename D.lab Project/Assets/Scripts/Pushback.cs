using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pushback : MonoBehaviour
{

    Rigidbody rb;
    public PlayerScript players;
    public GameObject Player;

    [SerializeField]
    private int pushval;

    void Start(){
        Player = GameObject.Find("Player");
        players = Player.GetComponent<PlayerScript>();
        rb = this.GetComponent<Rigidbody>();
    }

    void Update(){
        
        
    }

 void OnTriggerEnter(Collider col){
     if(col.gameObject.CompareTag("Player")){
         Vector3 move = new Vector3(0, 0, pushval);
         players.controller.Move(move * Time.deltaTime);
    	}
 }
}
