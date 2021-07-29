using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lifesSpt : MonoBehaviour{

    int life;
    public Text lifeText;
    // Start is called before the first frame update
    void Start(){
        this.life = 1;
    }

    public void removeLifes(){
        this.life --;
        if(this.life > 0){
            this.lifeText.text = life.ToString();
        } else {
            SceneManager.LoadScene("GameOver");
        }
    }

    // Update is called once per frame
    //void Update(){
    //    
    //}
}