using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testingBullet : MonoBehaviour
{
    public GameObject bullet;
    public float force = 1000f;



  

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject instBullet = Instantiate(bullet, transform.position, Quaternion.identity);
            instBullet.transform.rotation = transform.rotation;
            Rigidbody instBulletRigidbody = instBullet.GetComponent<Rigidbody>();
            instBulletRigidbody.AddForce(instBullet.transform.forward * force);
           
        }
    }
}

// create a script and attach to the bullet
// update()
// { trasform.forward  =  rb.velocity}