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
        this.life = 0;
    }

    public void removeLifes(){
        this.life --;
        if(this.life > 0){
            this.lifeText.text = life.ToString();
        } else {
            SceneManager.LoadScene("GameOver");
        }
    }

    public void addLifes(){
        this.life ++;
        this.lifeText.text = life.ToString();
        
        if(this.life == 3){
            SceneManager.LoadScene("GameGain");
        }
    }
    // Update is called once per frame
    //void Update(){
    //    
    //}
}