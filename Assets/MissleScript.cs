using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissleScript : MonoBehaviour
{
    Rigidbody2D rb;

    bool hasHit = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(hasHit == false){
            trackMovement();
        }
     
    }

    void trackMovement(){
        Vector2 direction = rb.velocity;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle,Vector3.forward);// applying the angle we just calculated
    }

    void OnCollisionEnter2d(Collision2D col){
        hasHit = true;
        rb.velocity = Vector2.zero;
        rb.isKinematic = true;
    }

}
