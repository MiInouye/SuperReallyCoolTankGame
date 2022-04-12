using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform playerTransform;
    //public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = transform.position;
        temp.x = playerTransform.position.x;
        temp.y = playerTransform.position.y;
        transform.position = temp;
        //transform.position = new Vector3(target.transform.position.x, target.x, -10);
    }
}
