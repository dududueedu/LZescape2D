using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death_spt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Translate(Vector3.right * (3.7f * Time.deltaTime));
        if(this.gameObject.transform.position.x < -60.0f){
            this.gameObject.transform.Translate(Vector3.left * 120.0f);
        }
        
    }
}
