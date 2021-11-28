using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameOver : MonoBehaviour
{
    [SerializeField] float delay = 0.2f;
    [SerializeField] Movement c;
    void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player" && !c.hitFinish ){
            Invoke("ReloadScene", delay);
        }
    }
    void ReloadScene(){
        SceneManager.LoadScene(1);
    }
}
