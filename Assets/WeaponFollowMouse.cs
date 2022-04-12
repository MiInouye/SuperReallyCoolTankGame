using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponFollowMouse : MonoBehaviour
{
    public float offset;

    public GameObject ammo;
    public float launchForce;
    public Transform shotPoint;

    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f,0f, rotZ + offset);

        if(Input.GetMouseButtonDown(0)){
            Shoot();
        }
    }
    void Shoot(){
        GameObject newAmmo =  Instantiate(ammo, shotPoint.position, transform.rotation);
        newAmmo.GetComponent<Rigidbody2D>().velocity = transform.right * launchForce;

    }

}
