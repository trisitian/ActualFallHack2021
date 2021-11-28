using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearObstacle : MonoBehaviour
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
           StartCoroutine(backMovement());

        }

    }

    IEnumerator backMovement(){
        float originalSpeed = cs.runSpeed;
           cs.runSpeed *= -1;
           Debug.Log("Beep boop");
           yield return new WaitForSeconds(1);
           cs.runSpeed = originalSpeed;
    }
}
