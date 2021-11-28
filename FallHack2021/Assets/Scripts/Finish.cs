using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    [SerializeField] float delay = 2f;
    [SerializeField] ParticleSystem p;
    [SerializeField] Movement cs;
    // Start is called before the first frame update

    void OnTriggerEnter2D(Collider2D col)   {
        if(col.tag == "Player") {
            Debug.Log("Triggered");
            cs.hitFinish = true;
            p.Play();
            Invoke("finishScene", delay);
        }
    }

    void finishScene()  {

        SceneManager.LoadScene("TristianScene");
    }

        
    
}
