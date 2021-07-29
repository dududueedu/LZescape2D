using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backGame : MonoBehaviour{
    // Start is called before the first frame update
    void Start(){}

    // Update is called once per frame
    void Update(){}

    public void BackGamer(){
        SceneManager.LoadScene("SampleScene");
    }
}