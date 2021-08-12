using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundCheck : MonoBehaviour{

    playerSpt Player;

    void Start(){
        Player = gameObject.transform.parent.gameObject.GetComponent<playerSpt>();
    }


    void OnCollisionEnter(Collision coll1){
        
        if(coll1.gameObject.layer == 6){
            Player.isJumping = false;
        }

    }

    void OnCollisionExit(Collision coll2){

        if(coll2.gameObject.layer == 6){
            Player.isJumping = true;
        }

    }    
}