using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour
{   
    bool isBoosted = true;

    [SerializeField] Movement cs;
    void Start(){
        
    }
    void OnTriggerEnter2D(Collider2D col){
        if(col.gameObject.tag == "Player" && isBoosted){
           cs.runSpeed+= 5;
           gameObject.GetComponent<SpriteRenderer>().enabled = false;
           isBoosted = false;
        }
    }
}
