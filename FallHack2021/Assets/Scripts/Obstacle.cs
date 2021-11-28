using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] Movement cs;
    public float speed = 0.5f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;
    float newSpeed;
   
    void Start () {

        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, speed);

     }

    void Update () {
        // if(transform.position.x < screenBounds.x * 2){
        //     Destroy(this.gameObject);
        // }
    }

    void OnCollisionEnter2D(Collision2D col){
       speed = speed * -1;
       rb.velocity = new Vector2(0, speed);

       if(col.gameObject.tag == "Player"){
           newSpeed = Mathf.Max(cs.runSpeed /2,2);
           cs.runSpeed = newSpeed;

        }

    }


}
