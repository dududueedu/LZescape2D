using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSpt : MonoBehaviour{
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        if(Input.GetKey(KeyCode.LeftArrow)) this.gameObject.transform.Translate( Vector3.left*0.01f );
        else if(Input.GetKey(KeyCode.RightArrow)) this.gameObject.transform.Translate( Vector3.right*0.01f );
        else if(Input.GetKey(KeyCode.UpArrow)) this.gameObject.transform.Translate( Vector3.forward*0.2f );
        else if(Input.GetKey(KeyCode.DownArrow)) this.gameObject.transform.Translate( Vector3.forward*-0.1f );
    }

    //void OnCollisionEnter(Collision coll){
      //  if(coll.gameObject.tag.Equals("bola")){
        //    coll.transform.position = new Vector3(Random.Range( -5.0f, 5.0f ), 0.5f, Random.Range( -5.0f, 5.0f ));
        //}
    //}
}