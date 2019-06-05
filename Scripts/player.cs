using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Rigidbody rb;
    public GameObject bullet;
    Rigidbody bulletrb;
    GameObject bulletclone;
    Rigidbody bulletrblone;

    void Start()
    {
        rb = GetComponent<Rigidbody>();   
    }

    void FixedUpdate()
    {
        float moveVer = Input.GetAxis("Vertical");
        rb.AddForce(transform.forward * moveVer * 20f);

        float moveHor = Input.GetAxis("Horizontal"); 
        transform.Rotate(0f, moveHor * 5f, 0f);

        if (Input.GetKeyDown("space")) {
            bulletclone = Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
            bulletrblone = bulletclone.GetComponent<Rigidbody>();
            bulletrblone.AddForce(transform.forward * 500f);
        }
    }
}
