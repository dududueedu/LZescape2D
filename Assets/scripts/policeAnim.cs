using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class policeAnim : MonoBehaviour{
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){

        if(Input.GetKey(KeyCode.RightArrow)){
            this.gameObject.GetComponent<Animator>().SetBool("pressed", true);
        }
        else if(Input.GetKey(KeyCode.LeftArrow)){
            this.gameObject.GetComponent<Animator>().SetBool("pressed", true);
        }
        else{
            this.gameObject.GetComponent<Animator>().SetBool("pressed", false);
        }

    }
}
