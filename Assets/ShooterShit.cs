using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterShit : MonoBehaviour
{
    public float LaunchForce;

    public GameObject Missle;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)){
            //hit e to launch missle
            Shoot();
        }
    }
    void Shoot(){
        GameObject MissileIns = Instantiate(Missle,transform.position,transform.rotation);

        MissileIns.GetComponent<Rigidbody2D>().AddForce(transform.right * LaunchForce);
        //MissileIns.GetComponent<Rigidbody2D>().velocity = transform.right * LaunchForce;
    }
}
