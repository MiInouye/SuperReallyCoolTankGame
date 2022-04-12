using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{
    public GameObject ammo;
    public float launchForce;
    public Transform shotPoint;


    void Update()
    {
        Vector2 bowPosition = transform.position;
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);//converts into where it is in the map (mouse position in pixels)
        Vector2 direction = mousePosition - bowPosition;
        transform.right = direction;

         if(Input.GetMouseButtonDown(0)){
            Shoot();
        }
    }
    void Shoot(){
        GameObject newAmmo =  Instantiate(ammo, shotPoint.position, shotPoint.rotation);
        newAmmo.GetComponent<Rigidbody2D>().velocity = transform.right * launchForce;

    }
}
