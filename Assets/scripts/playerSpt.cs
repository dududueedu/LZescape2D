using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerSpt : MonoBehaviour{

    Rigidbody rigidbody;
    public float jumpForce;
    //public float forc = 150f;

    void Start(){
        rigidbody = this.gameObject.GetComponent<Rigidbody>();
    }

    void Update(){
        if(Input.GetKey(KeyCode.LeftArrow)) this.gameObject.transform.Translate( Vector3.left*0.01f );
        else if(Input.GetKey(KeyCode.RightArrow)) this.gameObject.transform.Translate( Vector3.right*0.01f );
        //else if(Input.GetKey(KeyCode.Space)){
        //    rigidbody.AddForce(Vector3.up*forc);
        //}
        //else if(Input.GetKey(KeyCode.UpArrow)) this.gameObject.transform.Translate( Vector3.forward*0.2f );
        //else if(Input.GetKey(KeyCode.DownArrow)) this.gameObject.transform.Translate( Vector3.forward*-0.1f );
    }

    void OnCollisionEnter(Collision coll){
        if(coll.gameObject.tag.Equals("HOUSE")){
            Debug.Log("Vc ganhou!!!");
            SceneManager.LoadScene("GameOver");
        }
    }

    void Jump(){
        if(Input.GetButtonDown("Jump")){
            rigidbody.AddForce(new Vector2(0f, jumpForce), ForceMode.Impulse);
        }
    }
}